using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
			ConsultasVisibility(false);
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
			consultas.BackColor = c2;
			exames.BackColor = c2;
			cadastros.BackColor = c2;
			sair.BackColor = c2;
			x.BackColor = c3;
		}
		private void label3_Click_1(object sender, EventArgs e)
		{
			pressButton(telaInicial);
			ConsultasVisibility(false);
			MainVisibility(true);
		}
		private void MainVisibility(bool status)
		{
			pictureBoxImagem.Visible = status;
			pictureBoxName.Visible = status;
		}
		private void ConsultasVisibility(bool status)
		{
			panelConsultas.Visible = status;
			labelConsultasTitulo.Visible = status;
			labelConsultasNome.Visible = status;
			textBoxConsultasCadastroNome.Visible = status;
			labelCadastroTelefone.Visible = status;
			textBoxCadastroTelefone.Visible = status;
			labelCadastroPagamento.Visible = status;
			checkBoxPagamentoConvenio.Visible = status;
			checkBoxPagamentoParticular.Visible = status;
		}
		private void label4_Click(object sender, EventArgs e)
		{
			pressButton(consultas);
			MainVisibility(false);
			ConsultasVisibility(true);
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
		}

		private void cadastros_Click(object sender, EventArgs e)
		{
			pressButton(cadastros);
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
		private void checkBoxPagamentoConvenio_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxPagamentoConvenio.Checked)
			{
				checkBoxPagamentoParticular.Checked = false;
			}
		}
		private void checkBoxPagamentoParticular_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxPagamentoParticular.Checked)
			{
				checkBoxPagamentoConvenio.Checked = false;
			}
		}
	}
}
