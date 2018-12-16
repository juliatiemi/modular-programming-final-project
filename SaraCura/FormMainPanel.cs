using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Enums;

namespace SaraCura
{
	public partial class FormMainPanel : Form
	{
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		Color c1 = Color.FromArgb(201, 235, 242);
		Color c2 = Color.FromArgb(154, 199, 217);
		Color c3 = Color.FromArgb(101, 149, 191);
		Color c4 = Color.FromArgb(36, 119, 191);
		Color c5 = Color.FromArgb(57, 115, 115);
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		private const int cGrip = 16;
		private const int cCaption = 32;
		public FormMainPanel()
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			MainVisibility(true);
			CadastroVisibility(false);
			foreach(var item in Enum.GetValues(typeof(Especialidades)))
			{
				checkedListBoxEquipamentoEspecialidades.Items.Add(item);
			}
		}
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x84)
			{
				var p = new Point(m.LParam.ToInt32());
				p = PointToClient(p);
				if (p.Y == cCaption)
				{
					m.Result = (IntPtr)2;
					return;
				}
				if (p.X >= ClientSize.Width - cGrip && p.Y >= ClientSize.Height - cGrip)
				{
					m.Result = (IntPtr)17;
					return;
				}
			}
			base.WndProc(ref m);
		}
		private void label1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void label2_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		private void pressButton(Label x)
		{
			telaInicial.BackColor = c2;
			cadastros.BackColor = c2;
			exames.BackColor = c2;
			consultas.BackColor = c2;
			sair.BackColor = c2;
			x.BackColor = c3;
		}
		private void label3_Click_1(object sender, EventArgs e)
		{
			pressButton(telaInicial);
			panelMain.Visible = true;
			CadastroVisibility(false);
			MainVisibility(true);
		}
		private void MainVisibility(bool status)
		{
			pictureBoxImagem.Visible = status;
			pictureBoxName.Visible = status;
		}
		private void CadastroVisibility(bool status)
		{
			panelSelecaoCadastro.Visible = status;
			labelCadastroMedico.Visible = status;
			labelCadastroPaciente.Visible = status;
			labelCadastroEquipamento.Visible = status;
			CadastroPacienteVisibility(false);
			CadastroEquipamentoVisibility(false);
		}
		private void CadastroEquipamentoVisibility(bool status)
		{
			panelCadastroEquipamento.Visible = status;
			panelCadastroEquipamento.BringToFront();
			labelTitulocadastroEquipamento.Visible = status;
			labelCadastroEquipamentoID.Visible = status;
			textBoxCadastroEquipamentoID.Visible = status;
			textBoxCadastroEquipamentoTipo.Visible = status;
			labelCadastroEquipamentoEspecialidades.Visible = status;
			checkedListBoxEquipamentoEspecialidades.Visible = status;
			checkedListBoxEquipamentoEspecialidades.CheckOnClick = true;
			labelCadastroEquipamentoFinalizar.Visible = status;
		}
		private void CadastroPacienteVisibility(bool status)
		{
			panelConsultas.Visible = status;
			labelConsultasTitulo.Visible = status;
			labelConsultasNome.Visible = status;
			textBoxConsultasCadastroNome.Visible = status;
			labelCadastroTelefone.Visible = status;
			maskedTextBoxCadastroTelefone.Visible = status;
			labelCadastroPagamento.Visible = status;
			checkBoxPagamentoConvenio.Visible = status;
			checkBoxPagamentoParticular.Visible = status;
			labelCadastroEmail.Visible = status;
			textBoxCadastroEmail.Visible = status;
			CadastroConvenioVisibility(false);
			CadastroParticularVisibility(false);
		}
		private void CadastroConvenioVisibility(bool status)
		{
			panelCadastroConvenio.Visible = status;
			textBoxCadastroNomeConvênio.Visible = status;
			labelCadastroConvenioAutorizacao.Visible = status;
			labelCadastroConvenioNome.Visible = status;
			labelCadastroConvenioNumero.Visible = status;
		}
		private void CadastroParticularVisibility(bool status)
		{
			panelCadastroParticular.Visible = status;
			panelCadastroParticular.Visible = status;
			comboBoxPagamentos.Visible = status;
			labelCadastroParticularCartaoNome.Visible = status;
			textBoxCadastroParticularCartaoNome.Visible = status;
			CadastroParticularCartaoVisibility(false);
		}
		private void CadastroParticularCartaoVisibility(bool status)
		{
			panelCadastroParticularCartao.Visible = status;
			labelCadastroParticularCartaoNome.Visible = status;
			textBoxCadastroParticularCartaoNome.Visible = status;
			labelCadastroParticularCartaoNumero.Visible = status;
			maskedTextBoxCadastroParticularCartaoNumero.Visible = status;
			labelCadastroParticularCartaoCodigo.Visible = status;
			maskedTextBoxCadastroParticularCartaoCodigo.Visible = status;
			labelCadastroParticularCartaoCPF.Visible = status;
			labelCadastroParticularCartaofinalizar.Visible = status;
		}
		private void label4_Click(object sender, EventArgs e)
		{
			pressButton(cadastros);
			MainVisibility(false);
			CadastroVisibility(true);
		}
		private void sair_Click(object sender, EventArgs e)
		{
			pressButton(sair);
			var popup = MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo);
			if (popup is DialogResult.Yes)
			{
				Application.Exit();
			}
		}
		private void exames_Click(object sender, EventArgs e)
		{
			pressButton(exames);
			MainVisibility(false);
			CadastroVisibility(false);
		}
		private void cadastros_Click(object sender, EventArgs e)
		{
			pressButton(consultas);
		}
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		private void panel3_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		private void label3_Click_2(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
			}
			else
			{
				WindowState = FormWindowState.Maximized;
			}
		}
		private void label4_Click_1(object sender, EventArgs e)
		{

		}
		private void BoxPagamentoConvenioVisibility(bool status)
		{
			labelCadastroConvenioNome.Visible = status;
		}
		private void checkBoxPagamentoConvenio_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxPagamentoConvenio.Checked)
			{
				checkBoxPagamentoParticular.Checked = false;
				CadastroParticularVisibility(false);
				CadastroConvenioVisibility(true);
			}
			else
			{
				CadastroConvenioVisibility(false);
			}
		}
		private void checkBoxPagamentoParticular_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxPagamentoParticular.Checked)
			{
				checkBoxPagamentoConvenio.Checked = false;
				CadastroParticularVisibility(true);
				CadastroConvenioVisibility(false);
			}
			else
			{
				CadastroParticularVisibility(false);
			}
		}
		private void ClearCliente()
		{
			textBoxConsultasCadastroNome.Text = "";
			maskedTextBoxCadastroTelefone.Text = "";
			textBoxCadastroEmail.Text = "";
		}
		private void ClearConvenio()
		{
			ClearCliente();
			textBoxCadastroNomeConvênio.Text = "";
			textBoxConvenioMatriculacliente.Text = "";
		}
		private bool RegistroCliente(ref MailAddress email, ref uint telefone, ref string nome)
		{
			nome = textBoxConsultasCadastroNome.Text;
			if (!nome.All(char.IsLetter) || nome is "")
			{
				MessageBox.Show("Nome inválido!");
				textBoxConsultasCadastroNome.Text = "";
				return false;
			}
			try
			{
				telefone = uint.Parse(Regex.Replace(maskedTextBoxCadastroTelefone.Text, "[ ()-]", ""));
			}
			catch
			{
				MessageBox.Show("Telefone Inválido!");
				maskedTextBoxCadastroTelefone.Text = "";
				return false;
			}
			try
			{
				email = new MailAddress(textBoxCadastroEmail.Text);
			}
			catch
			{
				MessageBox.Show("E-Mail Inválido!");
				textBoxCadastroEmail.Text = "";
				return false;
			}
			return true;
		}
		private void labelCadastroConvenioAutorizacao_Click(object sender, EventArgs e)
		{
			MailAddress email = null;
			string nome = null, convenio;
			uint telefone = 0, matricula;
			if (RegistroCliente(ref email, ref telefone, ref nome))
			{
				
			}
			else return;
			convenio = textBoxCadastroNomeConvênio.Text;
			if (!convenio.All(char.IsLetter) || convenio is "")
			{
				MessageBox.Show("Nome do convênio inválido!");
				textBoxCadastroNomeConvênio.Text = "";
				return;
			}
			try
			{
				matricula = uint.Parse(textBoxConvenioMatriculacliente.Text);
			}
			catch
			{
				MessageBox.Show("Número de matrícula inválido!");
				textBoxConvenioMatriculacliente.Text = "";
				return;
			}
			MessageBox.Show("Cliente cadastrado com sucesso!");
			ClearConvenio();
		}
		private bool RegistroCartao(ref string nome, ref uint num, ref uint cpf, ref short codigo)
		{
			nome = textBoxCadastroParticularCartaoNome.Text;
			if(nome.All(char.IsLetter) || nome is "")
			{
				MessageBox.Show("Nome do cliente registrado no cartão inválido!");
				textBoxCadastroParticularCartaoNome.Text = "";
				return false;
			}
			try
			{
				num = uint.Parse(Regex.Replace(maskedTextBoxCadastroParticularCartaoNumero.Text, "[-]", ""));
			}
			catch
			{
				MessageBox.Show("Número do cartão inválido!");
				maskedTextBoxCadastroParticularCartaoNumero.Text = "";
				return false;
			}
			try
			{
				cpf = uint.Parse(Regex.Replace(maskedTextBoxCadastroParticularCartaoCPF.Text, "[.-]", ""));
			}
			catch
			{
				MessageBox.Show("CPF inválido!");
				maskedTextBoxCadastroParticularCartaoCPF.Text = "";
				return false;
			}
			try
			{
				codigo = short.Parse(maskedTextBoxCadastroParticularCartaoCodigo.Text);
			}
			catch
			{
				MessageBox.Show("Código do cartão inválido!");
				maskedTextBoxCadastroParticularCartaoCodigo.Text = "";
				return false;
			}
			return true;
		}
		private void comboBoxPagamentos_SelectedIndexChanged(object sender, EventArgs e)
		{
			MailAddress email = null;
			string nome = null, nomeCartao = null;
			uint telefone = 0, cpf = 0, num = 0;
			ushort codigo = 0;
			if (comboBoxPagamentos.SelectedItem is "Crédito")
			{
				CadastroParticularCartaoVisibility(true);
			}
			else if(comboBoxPagamentos.SelectedItem is "Cheque")
			{
				CadastroParticularCartaoVisibility(false);
				var confirm = MessageBox.Show("Confirmar Pagamento em cheque", "Aviso", MessageBoxButtons.OKCancel);
				if(confirm is DialogResult.OK)
				{
					if (RegistroCliente(ref email, ref telefone, ref nome))
					{
						MessageBox.Show("Cliente cadastrado com sucesso!");
					}
				}
			}
			else if(comboBoxPagamentos.SelectedItem is "Débito")
			{
				CadastroParticularCartaoVisibility(true);
			}
			else
			{
				CadastroParticularCartaoVisibility(false);
				var confirm = MessageBox.Show("Confirmar pagamento em dinheiro", "Aviso", MessageBoxButtons.OKCancel);
				if (confirm is DialogResult.OK)
				{
					if(RegistroCliente(ref email, ref telefone, ref nome))
					{
						MessageBox.Show("Cliente cadastrado com sucesso!");
					}
				}
			}
		}
		private void labelCadastroPaciente_Click(object sender, EventArgs e)
		{
			CadastroVisibility(false);
			CadastroPacienteVisibility(true);
		}
		private void ClearCartao()
		{
			maskedTextBoxCadastroParticularCartaoCodigo.Text = "";
			maskedTextBoxCadastroParticularCartaoCPF.Text = "";
			maskedTextBoxCadastroParticularCartaoNumero.Text = "";
			textBoxCadastroParticularCartaoNome.Text = "";
		}
		private void labelCadastroParticularCartaofinalizar_Click(object sender, EventArgs e)
		{
			MailAddress mail = null;
			short codigo = 0;
			string nome = null, nomeCartao = null;
			uint telefone = 0, num = 0, cpf = 0;
			if(RegistroCliente(ref mail, ref telefone, ref nome) && RegistroCartao(ref nomeCartao, ref num, ref cpf, ref codigo))
			{
				MessageBox.Show("Cliente Cadastrado com sucesso!");
				ClearCliente();
				ClearCartao();
			}
		}
		private void labelCadastroEquipamento_Click(object sender, EventArgs e)
		{
			CadastroVisibility(false);
			CadastroEquipamentoVisibility(true);
		}

		private void labelCadastroEquipamentoFinalizar_Click(object sender, EventArgs e)
		{
			string tipo;
			uint id;
			tipo = textBoxCadastroEquipamentoTipo.Text;
			if(tipo is "" || !tipo.All(char.IsLetter))
			{
				MessageBox.Show("Tipo inválido!");
				textBoxCadastroEquipamentoTipo.Text = "";
				return;
			}
			try
			{
				id = uint.Parse(textBoxCadastroEquipamentoID.Text);
			}
			catch
			{
				MessageBox.Show("ID inválido!");
				textBoxCadastroEquipamentoID.Text = "";
				return;
			}
			if(checkedListBoxEquipamentoEspecialidades.CheckedItems.Count is 0)
			{
				MessageBox.Show("Selecione pelo menos uma especialidade");
				return;
			}
			else
			{
				var lista_especialidades = checkedListBoxEquipamentoEspecialidades.SelectedItems;
			}
			MessageBox.Show("Equipamento cadastrado com sucesso!");
		}

		private void labelCadastroMedico_Click(object sender, EventArgs e)
		{

		}
	}
}
