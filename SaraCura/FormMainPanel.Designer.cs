namespace SaraCura
{
    partial class FormMainPanel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPanel));
			this.labelSair_X = new System.Windows.Forms.Label();
			this.panelBarraSuperior = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.labelMinimizar_ = new System.Windows.Forms.Label();
			this.labelMaximiza = new System.Windows.Forms.Label();
			this.panelBarraSuperiorEsquerda = new System.Windows.Forms.Panel();
			this.panelLateral = new System.Windows.Forms.Panel();
			this.sair = new System.Windows.Forms.Label();
			this.cadastros = new System.Windows.Forms.Label();
			this.exames = new System.Windows.Forms.Label();
			this.consultas = new System.Windows.Forms.Label();
			this.telaInicial = new System.Windows.Forms.Label();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
			this.pictureBoxName = new System.Windows.Forms.Label();
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelConsultas = new System.Windows.Forms.Panel();
			this.checkBoxPagamentoParticular = new System.Windows.Forms.CheckBox();
			this.checkBoxPagamentoConvenio = new System.Windows.Forms.CheckBox();
			this.labelCadastroPagamento = new System.Windows.Forms.Label();
			this.textBoxCadastroTelefone = new System.Windows.Forms.TextBox();
			this.labelCadastroTelefone = new System.Windows.Forms.Label();
			this.textBoxConsultasCadastroNome = new System.Windows.Forms.TextBox();
			this.labelConsultasNome = new System.Windows.Forms.Label();
			this.labelConsultasTitulo = new System.Windows.Forms.Label();
			this.panelBarraSuperior.SuspendLayout();
			this.panelLateral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
			this.panelMain.SuspendLayout();
			this.panelConsultas.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelSair_X
			// 
			this.labelSair_X.AutoSize = true;
			this.labelSair_X.Cursor = System.Windows.Forms.Cursors.Default;
			this.labelSair_X.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelSair_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSair_X.ForeColor = System.Drawing.Color.White;
			this.labelSair_X.Location = new System.Drawing.Point(783, 0);
			this.labelSair_X.Name = "labelSair_X";
			this.labelSair_X.Size = new System.Drawing.Size(17, 16);
			this.labelSair_X.TabIndex = 1;
			this.labelSair_X.Text = "X";
			this.labelSair_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelSair_X.Click += new System.EventHandler(this.label1_Click);
			// 
			// panelBarraSuperior
			// 
			this.panelBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
			this.panelBarraSuperior.Controls.Add(this.label1);
			this.panelBarraSuperior.Controls.Add(this.labelMinimizar_);
			this.panelBarraSuperior.Controls.Add(this.labelMaximiza);
			this.panelBarraSuperior.Controls.Add(this.panelBarraSuperiorEsquerda);
			this.panelBarraSuperior.Controls.Add(this.labelSair_X);
			this.panelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBarraSuperior.Location = new System.Drawing.Point(0, 0);
			this.panelBarraSuperior.Name = "panelBarraSuperior";
			this.panelBarraSuperior.Size = new System.Drawing.Size(800, 24);
			this.panelBarraSuperior.TabIndex = 3;
			this.panelBarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(186, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Sistema SaraCura";
			// 
			// labelMinimizar_
			// 
			this.labelMinimizar_.AutoSize = true;
			this.labelMinimizar_.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelMinimizar_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMinimizar_.ForeColor = System.Drawing.Color.White;
			this.labelMinimizar_.Location = new System.Drawing.Point(751, 0);
			this.labelMinimizar_.Name = "labelMinimizar_";
			this.labelMinimizar_.Size = new System.Drawing.Size(18, 16);
			this.labelMinimizar_.TabIndex = 5;
			this.labelMinimizar_.Text = "—";
			this.labelMinimizar_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelMaximiza
			// 
			this.labelMaximiza.AutoSize = true;
			this.labelMaximiza.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelMaximiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMaximiza.ForeColor = System.Drawing.Color.White;
			this.labelMaximiza.Location = new System.Drawing.Point(769, 0);
			this.labelMaximiza.Name = "labelMaximiza";
			this.labelMaximiza.Size = new System.Drawing.Size(14, 13);
			this.labelMaximiza.TabIndex = 4;
			this.labelMaximiza.Text = "⎕";
			this.labelMaximiza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMaximiza.Click += new System.EventHandler(this.label3_Click_2);
			// 
			// panelBarraSuperiorEsquerda
			// 
			this.panelBarraSuperiorEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(191)))));
			this.panelBarraSuperiorEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelBarraSuperiorEsquerda.Location = new System.Drawing.Point(0, 0);
			this.panelBarraSuperiorEsquerda.Name = "panelBarraSuperiorEsquerda";
			this.panelBarraSuperiorEsquerda.Size = new System.Drawing.Size(180, 24);
			this.panelBarraSuperiorEsquerda.TabIndex = 3;
			this.panelBarraSuperiorEsquerda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
			// 
			// panelLateral
			// 
			this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
			this.panelLateral.Controls.Add(this.sair);
			this.panelLateral.Controls.Add(this.cadastros);
			this.panelLateral.Controls.Add(this.exames);
			this.panelLateral.Controls.Add(this.consultas);
			this.panelLateral.Controls.Add(this.telaInicial);
			this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLateral.Location = new System.Drawing.Point(0, 24);
			this.panelLateral.Name = "panelLateral";
			this.panelLateral.Size = new System.Drawing.Size(180, 576);
			this.panelLateral.TabIndex = 4;
			// 
			// sair
			// 
			this.sair.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sair.ForeColor = System.Drawing.Color.White;
			this.sair.Location = new System.Drawing.Point(0, 200);
			this.sair.Name = "sair";
			this.sair.Size = new System.Drawing.Size(180, 50);
			this.sair.TabIndex = 9;
			this.sair.Text = "   Sair";
			this.sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.sair.Click += new System.EventHandler(this.sair_Click);
			// 
			// cadastros
			// 
			this.cadastros.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cadastros.ForeColor = System.Drawing.Color.White;
			this.cadastros.Location = new System.Drawing.Point(0, 150);
			this.cadastros.Name = "cadastros";
			this.cadastros.Size = new System.Drawing.Size(180, 50);
			this.cadastros.TabIndex = 8;
			this.cadastros.Text = "   Cadastros";
			this.cadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cadastros.Click += new System.EventHandler(this.cadastros_Click);
			// 
			// exames
			// 
			this.exames.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exames.ForeColor = System.Drawing.Color.White;
			this.exames.Location = new System.Drawing.Point(0, 100);
			this.exames.Name = "exames";
			this.exames.Size = new System.Drawing.Size(180, 50);
			this.exames.TabIndex = 7;
			this.exames.Text = "   Exames";
			this.exames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.exames.Click += new System.EventHandler(this.exames_Click);
			// 
			// consultas
			// 
			this.consultas.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consultas.ForeColor = System.Drawing.Color.White;
			this.consultas.Location = new System.Drawing.Point(0, 50);
			this.consultas.Name = "consultas";
			this.consultas.Size = new System.Drawing.Size(180, 50);
			this.consultas.TabIndex = 6;
			this.consultas.Text = "   Consultas";
			this.consultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.consultas.Click += new System.EventHandler(this.label4_Click);
			// 
			// telaInicial
			// 
			this.telaInicial.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.telaInicial.ForeColor = System.Drawing.Color.White;
			this.telaInicial.Location = new System.Drawing.Point(0, 0);
			this.telaInicial.Name = "telaInicial";
			this.telaInicial.Size = new System.Drawing.Size(180, 50);
			this.telaInicial.TabIndex = 5;
			this.telaInicial.Text = "   Tela Inicial";
			this.telaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.telaInicial.Click += new System.EventHandler(this.label3_Click_1);
			// 
			// pictureBoxImagem
			// 
			this.pictureBoxImagem.Image = global::SaraCura.Properties.Resources.image11;
			this.pictureBoxImagem.Location = new System.Drawing.Point(147, 44);
			this.pictureBoxImagem.Name = "pictureBoxImagem";
			this.pictureBoxImagem.Size = new System.Drawing.Size(304, 294);
			this.pictureBoxImagem.TabIndex = 5;
			this.pictureBoxImagem.TabStop = false;
			// 
			// pictureBoxName
			// 
			this.pictureBoxName.AutoSize = true;
			this.pictureBoxName.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxName.Font = new System.Drawing.Font("Yu Mincho", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pictureBoxName.ForeColor = System.Drawing.Color.Teal;
			this.pictureBoxName.Location = new System.Drawing.Point(175, 341);
			this.pictureBoxName.Name = "pictureBoxName";
			this.pictureBoxName.Size = new System.Drawing.Size(231, 124);
			this.pictureBoxName.TabIndex = 6;
			this.pictureBoxName.Text = "  Clínica\r\nSaraCura";
			this.pictureBoxName.Click += new System.EventHandler(this.label4_Click_1);
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.panelConsultas);
			this.panelMain.Controls.Add(this.pictureBoxName);
			this.panelMain.Controls.Add(this.pictureBoxImagem);
			this.panelMain.Location = new System.Drawing.Point(186, 30);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(597, 558);
			this.panelMain.TabIndex = 5;
			// 
			// panelConsultas
			// 
			this.panelConsultas.Controls.Add(this.checkBoxPagamentoParticular);
			this.panelConsultas.Controls.Add(this.checkBoxPagamentoConvenio);
			this.panelConsultas.Controls.Add(this.labelCadastroPagamento);
			this.panelConsultas.Controls.Add(this.textBoxCadastroTelefone);
			this.panelConsultas.Controls.Add(this.labelCadastroTelefone);
			this.panelConsultas.Controls.Add(this.textBoxConsultasCadastroNome);
			this.panelConsultas.Controls.Add(this.labelConsultasNome);
			this.panelConsultas.Controls.Add(this.labelConsultasTitulo);
			this.panelConsultas.Location = new System.Drawing.Point(0, 0);
			this.panelConsultas.Name = "panelConsultas";
			this.panelConsultas.Size = new System.Drawing.Size(597, 558);
			this.panelConsultas.TabIndex = 7;
			this.panelConsultas.Visible = false;
			// 
			// checkBoxPagamentoParticular
			// 
			this.checkBoxPagamentoParticular.AutoSize = true;
			this.checkBoxPagamentoParticular.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxPagamentoParticular.ForeColor = System.Drawing.Color.Teal;
			this.checkBoxPagamentoParticular.Location = new System.Drawing.Point(316, 202);
			this.checkBoxPagamentoParticular.Name = "checkBoxPagamentoParticular";
			this.checkBoxPagamentoParticular.Size = new System.Drawing.Size(128, 29);
			this.checkBoxPagamentoParticular.TabIndex = 7;
			this.checkBoxPagamentoParticular.Text = "Particular";
			this.checkBoxPagamentoParticular.UseVisualStyleBackColor = true;
			this.checkBoxPagamentoParticular.CheckedChanged += new System.EventHandler(this.checkBoxPagamentoParticular_CheckedChanged);
			// 
			// checkBoxPagamentoConvenio
			// 
			this.checkBoxPagamentoConvenio.AutoSize = true;
			this.checkBoxPagamentoConvenio.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxPagamentoConvenio.ForeColor = System.Drawing.Color.Teal;
			this.checkBoxPagamentoConvenio.Location = new System.Drawing.Point(23, 194);
			this.checkBoxPagamentoConvenio.Name = "checkBoxPagamentoConvenio";
			this.checkBoxPagamentoConvenio.Size = new System.Drawing.Size(121, 29);
			this.checkBoxPagamentoConvenio.TabIndex = 6;
			this.checkBoxPagamentoConvenio.Text = "Convênio";
			this.checkBoxPagamentoConvenio.UseVisualStyleBackColor = true;
			this.checkBoxPagamentoConvenio.CheckedChanged += new System.EventHandler(this.checkBoxPagamentoConvenio_CheckedChanged);
			// 
			// labelCadastroPagamento
			// 
			this.labelCadastroPagamento.AutoSize = true;
			this.labelCadastroPagamento.Font = new System.Drawing.Font("Yu Gothic Medium", 16.25F, System.Drawing.FontStyle.Bold);
			this.labelCadastroPagamento.ForeColor = System.Drawing.Color.Teal;
			this.labelCadastroPagamento.Location = new System.Drawing.Point(18, 144);
			this.labelCadastroPagamento.Name = "labelCadastroPagamento";
			this.labelCadastroPagamento.Size = new System.Drawing.Size(249, 29);
			this.labelCadastroPagamento.TabIndex = 5;
			this.labelCadastroPagamento.Text = "Forma De Pagamento";
			// 
			// textBoxCadastroTelefone
			// 
			this.textBoxCadastroTelefone.Location = new System.Drawing.Point(128, 113);
			this.textBoxCadastroTelefone.Name = "textBoxCadastroTelefone";
			this.textBoxCadastroTelefone.Size = new System.Drawing.Size(417, 20);
			this.textBoxCadastroTelefone.TabIndex = 4;
			// 
			// labelCadastroTelefone
			// 
			this.labelCadastroTelefone.AutoSize = true;
			this.labelCadastroTelefone.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
			this.labelCadastroTelefone.ForeColor = System.Drawing.Color.Teal;
			this.labelCadastroTelefone.Location = new System.Drawing.Point(16, 107);
			this.labelCadastroTelefone.Name = "labelCadastroTelefone";
			this.labelCadastroTelefone.Size = new System.Drawing.Size(103, 25);
			this.labelCadastroTelefone.TabIndex = 3;
			this.labelCadastroTelefone.Text = "Telefone:";
			this.labelCadastroTelefone.Visible = false;
			// 
			// textBoxConsultasCadastroNome
			// 
			this.textBoxConsultasCadastroNome.Location = new System.Drawing.Point(96, 71);
			this.textBoxConsultasCadastroNome.Name = "textBoxConsultasCadastroNome";
			this.textBoxConsultasCadastroNome.Size = new System.Drawing.Size(449, 20);
			this.textBoxConsultasCadastroNome.TabIndex = 2;
			this.textBoxConsultasCadastroNome.Visible = false;
			// 
			// labelConsultasNome
			// 
			this.labelConsultasNome.AutoSize = true;
			this.labelConsultasNome.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConsultasNome.ForeColor = System.Drawing.Color.Teal;
			this.labelConsultasNome.Location = new System.Drawing.Point(16, 66);
			this.labelConsultasNome.Name = "labelConsultasNome";
			this.labelConsultasNome.Size = new System.Drawing.Size(74, 25);
			this.labelConsultasNome.TabIndex = 1;
			this.labelConsultasNome.Text = "Nome:";
			this.labelConsultasNome.Visible = false;
			// 
			// labelConsultasTitulo
			// 
			this.labelConsultasTitulo.AutoSize = true;
			this.labelConsultasTitulo.Font = new System.Drawing.Font("Yu Gothic Medium", 16.25F, System.Drawing.FontStyle.Bold);
			this.labelConsultasTitulo.ForeColor = System.Drawing.Color.Teal;
			this.labelConsultasTitulo.Location = new System.Drawing.Point(14, 16);
			this.labelConsultasTitulo.Name = "labelConsultasTitulo";
			this.labelConsultasTitulo.Size = new System.Drawing.Size(253, 29);
			this.labelConsultasTitulo.TabIndex = 0;
			this.labelConsultasTitulo.Text = "Cadastro Do Paciente";
			this.labelConsultasTitulo.Visible = false;
			// 
			// FormMainPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelLateral);
			this.Controls.Add(this.panelBarraSuperior);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "FormMainPanel";
			this.Text = "Sistema SaraCura";
			this.panelBarraSuperior.ResumeLayout(false);
			this.panelBarraSuperior.PerformLayout();
			this.panelLateral.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.panelConsultas.ResumeLayout(false);
			this.panelConsultas.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSair_X;
        private System.Windows.Forms.Panel panelBarraSuperior;
        private System.Windows.Forms.Panel panelBarraSuperiorEsquerda;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label telaInicial;
        private System.Windows.Forms.Label consultas;
        private System.Windows.Forms.Label sair;
        private System.Windows.Forms.Label cadastros;
        private System.Windows.Forms.Label exames;
        private System.Windows.Forms.Label labelMaximiza;
		private System.Windows.Forms.Label labelMinimizar_;
		private System.Windows.Forms.PictureBox pictureBoxImagem;
		private System.Windows.Forms.Label pictureBoxName;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Panel panelConsultas;
		private System.Windows.Forms.Label labelConsultasTitulo;
		private System.Windows.Forms.Label labelConsultasNome;
		private System.Windows.Forms.TextBox textBoxConsultasCadastroNome;
		private System.Windows.Forms.TextBox textBoxCadastroTelefone;
		private System.Windows.Forms.Label labelCadastroTelefone;
		private System.Windows.Forms.Label labelCadastroPagamento;
		private System.Windows.Forms.CheckBox checkBoxPagamentoConvenio;
		private System.Windows.Forms.CheckBox checkBoxPagamentoParticular;
		private System.Windows.Forms.Label label1;
	}
}

