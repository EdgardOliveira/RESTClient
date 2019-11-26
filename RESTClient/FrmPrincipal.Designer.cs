namespace RESTClient
{
    partial class frmPrincipal
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
            this.tabctrlConfiguracoes = new System.Windows.Forms.TabControl();
            this.tabpgRequisicao = new System.Windows.Forms.TabPage();
            this.cbbbxRecurso = new System.Windows.Forms.ComboBox();
            this.lblRecurso = new System.Windows.Forms.Label();
            this.lstbxRequisicaoCorpo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbxTipoConteudo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbxUri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbxMetodoRequisicao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpgParametros = new System.Windows.Forms.TabPage();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnNovaRequisicao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstbxRespostaCabecalho = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lstbxRespostaCorpo = new System.Windows.Forms.ListBox();
            this.tabctrlConfiguracoes.SuspendLayout();
            this.tabpgRequisicao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrlConfiguracoes
            // 
            this.tabctrlConfiguracoes.Controls.Add(this.tabpgRequisicao);
            this.tabctrlConfiguracoes.Controls.Add(this.tabpgParametros);
            this.tabctrlConfiguracoes.Location = new System.Drawing.Point(12, 12);
            this.tabctrlConfiguracoes.Name = "tabctrlConfiguracoes";
            this.tabctrlConfiguracoes.SelectedIndex = 0;
            this.tabctrlConfiguracoes.Size = new System.Drawing.Size(547, 318);
            this.tabctrlConfiguracoes.TabIndex = 0;
            // 
            // tabpgRequisicao
            // 
            this.tabpgRequisicao.Controls.Add(this.cbbbxRecurso);
            this.tabpgRequisicao.Controls.Add(this.lblRecurso);
            this.tabpgRequisicao.Controls.Add(this.lstbxRequisicaoCorpo);
            this.tabpgRequisicao.Controls.Add(this.label4);
            this.tabpgRequisicao.Controls.Add(this.cbbxTipoConteudo);
            this.tabpgRequisicao.Controls.Add(this.label3);
            this.tabpgRequisicao.Controls.Add(this.cbbxUri);
            this.tabpgRequisicao.Controls.Add(this.label2);
            this.tabpgRequisicao.Controls.Add(this.cbbxMetodoRequisicao);
            this.tabpgRequisicao.Controls.Add(this.label1);
            this.tabpgRequisicao.Location = new System.Drawing.Point(4, 22);
            this.tabpgRequisicao.Name = "tabpgRequisicao";
            this.tabpgRequisicao.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgRequisicao.Size = new System.Drawing.Size(539, 292);
            this.tabpgRequisicao.TabIndex = 0;
            this.tabpgRequisicao.Text = "Requisição";
            this.tabpgRequisicao.UseVisualStyleBackColor = true;
            // 
            // cbbbxRecurso
            // 
            this.cbbbxRecurso.FormattingEnabled = true;
            this.cbbbxRecurso.Items.AddRange(new object[] {
            "Attendants/",
            "Deliveries/"});
            this.cbbbxRecurso.Location = new System.Drawing.Point(348, 89);
            this.cbbbxRecurso.Name = "cbbbxRecurso";
            this.cbbbxRecurso.Size = new System.Drawing.Size(170, 21);
            this.cbbbxRecurso.TabIndex = 9;
            // 
            // lblRecurso
            // 
            this.lblRecurso.AutoSize = true;
            this.lblRecurso.Location = new System.Drawing.Point(345, 73);
            this.lblRecurso.Name = "lblRecurso";
            this.lblRecurso.Size = new System.Drawing.Size(47, 13);
            this.lblRecurso.TabIndex = 8;
            this.lblRecurso.Text = "Recurso";
            // 
            // lstbxRequisicaoCorpo
            // 
            this.lstbxRequisicaoCorpo.FormattingEnabled = true;
            this.lstbxRequisicaoCorpo.Location = new System.Drawing.Point(20, 147);
            this.lstbxRequisicaoCorpo.Name = "lstbxRequisicaoCorpo";
            this.lstbxRequisicaoCorpo.Size = new System.Drawing.Size(498, 134);
            this.lstbxRequisicaoCorpo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Corpo";
            // 
            // cbbxTipoConteudo
            // 
            this.cbbxTipoConteudo.FormattingEnabled = true;
            this.cbbxTipoConteudo.Items.AddRange(new object[] {
            "application/json"});
            this.cbbxTipoConteudo.Location = new System.Drawing.Point(179, 39);
            this.cbbxTipoConteudo.Name = "cbbxTipoConteudo";
            this.cbbxTipoConteudo.Size = new System.Drawing.Size(339, 21);
            this.cbbxTipoConteudo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de conteúdo";
            // 
            // cbbxUri
            // 
            this.cbbxUri.FormattingEnabled = true;
            this.cbbxUri.Items.AddRange(new object[] {
            "http://127.0.0.1:212/datasnap/rest/TSM/"});
            this.cbbxUri.Location = new System.Drawing.Point(20, 89);
            this.cbbxUri.Name = "cbbxUri";
            this.cbbxUri.Size = new System.Drawing.Size(300, 21);
            this.cbbxUri.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base Uri";
            // 
            // cbbxMetodoRequisicao
            // 
            this.cbbxMetodoRequisicao.FormattingEnabled = true;
            this.cbbxMetodoRequisicao.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "PATCH"});
            this.cbbxMetodoRequisicao.Location = new System.Drawing.Point(20, 39);
            this.cbbxMetodoRequisicao.Name = "cbbxMetodoRequisicao";
            this.cbbxMetodoRequisicao.Size = new System.Drawing.Size(133, 21);
            this.cbbxMetodoRequisicao.TabIndex = 1;
            this.cbbxMetodoRequisicao.SelectedValueChanged += new System.EventHandler(this.cbbxMetodoRequisicao_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método";
            // 
            // tabpgParametros
            // 
            this.tabpgParametros.Location = new System.Drawing.Point(4, 22);
            this.tabpgParametros.Name = "tabpgParametros";
            this.tabpgParametros.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgParametros.Size = new System.Drawing.Size(539, 292);
            this.tabpgParametros.TabIndex = 1;
            this.tabpgParametros.Text = "Parâmetros";
            this.tabpgParametros.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(565, 34);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(98, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_ClickAsync);
            // 
            // btnNovaRequisicao
            // 
            this.btnNovaRequisicao.Location = new System.Drawing.Point(565, 71);
            this.btnNovaRequisicao.Name = "btnNovaRequisicao";
            this.btnNovaRequisicao.Size = new System.Drawing.Size(98, 23);
            this.btnNovaRequisicao.TabIndex = 2;
            this.btnNovaRequisicao.Text = "Nova requisição";
            this.btnNovaRequisicao.UseVisualStyleBackColor = true;
            this.btnNovaRequisicao.Click += new System.EventHandler(this.btnNovaRequisicao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(565, 105);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(565, 143);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(98, 23);
            this.btnCarregar.TabIndex = 4;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl2);
            this.groupBox1.Location = new System.Drawing.Point(12, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 197);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resposta";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(3, 16);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(541, 178);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstbxRespostaCabecalho);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(533, 152);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Cabeçalho";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstbxRespostaCabecalho
            // 
            this.lstbxRespostaCabecalho.FormattingEnabled = true;
            this.lstbxRespostaCabecalho.Location = new System.Drawing.Point(18, 9);
            this.lstbxRespostaCabecalho.Name = "lstbxRespostaCabecalho";
            this.lstbxRespostaCabecalho.Size = new System.Drawing.Size(497, 134);
            this.lstbxRespostaCabecalho.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstbxRespostaCorpo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(533, 152);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Corpo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstbxRespostaCorpo
            // 
            this.lstbxRespostaCorpo.FormattingEnabled = true;
            this.lstbxRespostaCorpo.Location = new System.Drawing.Point(18, 9);
            this.lstbxRespostaCorpo.Name = "lstbxRespostaCorpo";
            this.lstbxRespostaCorpo.Size = new System.Drawing.Size(497, 134);
            this.lstbxRespostaCorpo.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovaRequisicao);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tabctrlConfiguracoes);
            this.Name = "frmPrincipal";
            this.Text = "RESTClient";
            this.tabctrlConfiguracoes.ResumeLayout(false);
            this.tabpgRequisicao.ResumeLayout(false);
            this.tabpgRequisicao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlConfiguracoes;
        private System.Windows.Forms.TabPage tabpgRequisicao;
        private System.Windows.Forms.ListBox lstbxRequisicaoCorpo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbxTipoConteudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbxUri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbxMetodoRequisicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabpgParametros;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnNovaRequisicao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cbbbxRecurso;
        private System.Windows.Forms.Label lblRecurso;
        private System.Windows.Forms.ListBox lstbxRespostaCabecalho;
        private System.Windows.Forms.ListBox lstbxRespostaCorpo;
    }
}

