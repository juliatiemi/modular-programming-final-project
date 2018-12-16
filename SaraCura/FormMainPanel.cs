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
using Clinica;

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
        private Sessao _sessao;

		public FormMainPanel(Sessao sessao)
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			MainVisibility(true);
			CadastroVisibility(false);
            _sessao = sessao;
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
			CadastroPacienteVisibility(false);
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
			if (popup == DialogResult.Yes)
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
		}

		private void checkBoxPagamentoParticular_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxPagamentoParticular.Checked)
			{
				checkBoxPagamentoConvenio.Checked = false;
				CadastroParticularVisibility(true);
				CadastroConvenioVisibility(false);
			}
		}

		private void labelCadastroConvenioAutorizacao_Click(object sender, EventArgs e)
		{
			MailAddress email;
            string nome, convenio;
			long telefone, matricula;
			nome = textBoxConsultasCadastroNome.Text;
			if(!nome.All(char.IsLetter))
			{
				MessageBox.Show("Nome inválido!");
				textBoxConsultasCadastroNome.Text = "";
				return;
			}
			try
			{
				telefone = long.Parse(maskedTextBoxCadastroTelefone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", ""));
			}
			catch
			{
				MessageBox.Show("Telefone Inválido!");
				maskedTextBoxCadastroTelefone.Text = "";
				return;
			}
			email = new MailAddress(textBoxCadastroEmail.Text);
			convenio = textBoxCadastroNomeConvênio.Text;
			try
			{
				matricula = long.Parse(textBoxConvenioMatriculacliente.Text);
			}
			catch
			{
				MessageBox.Show("Número de matrícula inválido!");
				textBoxConvenioMatriculacliente.Text = "";
				return;
			}
            try
            {
                Paciente paciente = new Paciente(nome, email.ToString(), telefone.ToString(), matricula.ToString());
                paciente.AdicionarPaciente(_sessao.PacientesCadastrados, paciente);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Paciente cadastrado com sucesso.");
            //otavio me ajuda a ir pra pagina inicial aqui
        }

        private void comboBoxPagamentos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxPagamentos.SelectedItem.Equals("Crédito"))
			{
				CadastroParticularCartaoVisibility(true);
			}
			else if(comboBoxPagamentos.SelectedItem.Equals("Cheque"))
			{
				CadastroParticularCartaoVisibility(false);
				var confirm = MessageBox.Show("Confirmar Pagamento em cheque:", "Aviso", MessageBoxButtons.OKCancel);
			}
			else if(comboBoxPagamentos.SelectedItem.Equals("Débito"))
			{
				CadastroParticularCartaoVisibility(true);
			}
			else
			{
				CadastroParticularCartaoVisibility(false);
				var confirm = MessageBox.Show("Confirmar pagamento em dinheiro:", "Aviso", MessageBoxButtons.OKCancel);
			}
		}

		private void labelCadastroParticularChequeDinheiroFinalizar_Click(object sender, EventArgs e)
		{

		}

		private void labelCadastroPaciente_Click(object sender, EventArgs e)
		{
			CadastroVisibility(false);
			CadastroPacienteVisibility(true);
		}
	}
}
