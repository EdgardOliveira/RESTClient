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
            this.tbctrResposta = new System.Windows.Forms.TabControl();
            this.tbpgCabecalho = new System.Windows.Forms.TabPage();
            this.lstbxRespostaCabecalho = new System.Windows.Forms.ListBox();
            this.tbpgCorpo = new System.Windows.Forms.TabPage();
            this.lstbxRespostaCorpo = new System.Windows.Forms.ListBox();
            this.tabctrlConfiguracoes.SuspendLayout();
            this.tabpgRequisicao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbctrResposta.SuspendLayout();
            this.tbpgCabecalho.SuspendLayout();
            this.tbpgCorpo.SuspendLayout();
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
            "Deliveries/",
            "69050001/json/"});
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
            "application/json",
            "application/xml",
            "application/html"});
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
            "http://127.0.0.1:212/datasnap/rest/TSM/",
            "https://viacep.com.br/ws/"});
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
            this.cbbxMetodoRequisicao.SelectedIndexChanged += new System.EventHandler(this.cbbxMetodoRequisicao_SelectedIndexChanged);
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
            this.btnSalvar.Visible = false;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(565, 143);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(98, 23);
            this.btnCarregar.TabIndex = 4;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbctrResposta);
            this.groupBox1.Location = new System.Drawing.Point(12, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 197);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resposta";
            // 
            // tbctrResposta
            // 
            this.tbctrResposta.Controls.Add(this.tbpgCabecalho);
            this.tbctrResposta.Controls.Add(this.tbpgCorpo);
            this.tbctrResposta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbctrResposta.Location = new System.Drawing.Point(3, 16);
            this.tbctrResposta.Multiline = true;
            this.tbctrResposta.Name = "tbctrResposta";
            this.tbctrResposta.SelectedIndex = 0;
            this.tbctrResposta.Size = new System.Drawing.Size(541, 178);
            this.tbctrResposta.TabIndex = 7;
            // 
            // tbpgCabecalho
            // 
            this.tbpgCabecalho.Controls.Add(this.lstbxRespostaCabecalho);
            this.tbpgCabecalho.Location = new System.Drawing.Point(4, 22);
            this.tbpgCabecalho.Name = "tbpgCabecalho";
            this.tbpgCabecalho.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgCabecalho.Size = new System.Drawing.Size(533, 152);
            this.tbpgCabecalho.TabIndex = 0;
            this.tbpgCabecalho.Text = "Cabeçalho";
            this.tbpgCabecalho.UseVisualStyleBackColor = true;
            // 
            // lstbxRespostaCabecalho
            // 
            this.lstbxRespostaCabecalho.FormattingEnabled = true;
            this.lstbxRespostaCabecalho.Location = new System.Drawing.Point(18, 9);
            this.lstbxRespostaCabecalho.Name = "lstbxRespostaCabecalho";
            this.lstbxRespostaCabecalho.Size = new System.Drawing.Size(497, 134);
            this.lstbxRespostaCabecalho.TabIndex = 10;
            // 
            // tbpgCorpo
            // 
            this.tbpgCorpo.Controls.Add(this.lstbxRespostaCorpo);
            this.tbpgCorpo.Location = new System.Drawing.Point(4, 22);
            this.tbpgCorpo.Name = "tbpgCorpo";
            this.tbpgCorpo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgCorpo.Size = new System.Drawing.Size(533, 152);
            this.tbpgCorpo.TabIndex = 1;
            this.tbpgCorpo.Text = "Corpo";
            this.tbpgCorpo.UseVisualStyleBackColor = true;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESTClient";
            this.tabctrlConfiguracoes.ResumeLayout(false);
            this.tabpgRequisicao.ResumeLayout(false);
            this.tabpgRequisicao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tbctrResposta.ResumeLayout(false);
            this.tbpgCabecalho.ResumeLayout(false);
            this.tbpgCorpo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlConfiguracoes;
        private System.Windows.Forms.TabPage tabpgRequisicao;
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
        private System.Windows.Forms.TabControl tbctrResposta;
        private System.Windows.Forms.TabPage tbpgCabecalho;
        private System.Windows.Forms.TabPage tbpgCorpo;
        private System.Windows.Forms.ComboBox cbbbxRecurso;
        private System.Windows.Forms.Label lblRecurso;
        private System.Windows.Forms.ListBox lstbxRespostaCabecalho;
        private System.Windows.Forms.ListBox lstbxRespostaCorpo;
    }
}

