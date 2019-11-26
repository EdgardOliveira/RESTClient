using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTClient
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cbbxMetodoRequisicao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbxMetodoRequisicao.Text.Equals("GET"))
                lstbxRequisicaoCorpo.Enabled = false;
            else
                lstbxRequisicaoCorpo.Enabled = true;
        }

        private async void btnEnviar_ClickAsync(object sender, EventArgs e)
        {
            //Instanciando a classe e passando parâmetros no construtor
            RESTClient restClient = new RESTClient(cbbxUri.Text, cbbbxRecurso.Text, 1, null);
            //obtendo dados - GET
            await restClient.GET();


            Task taskGET = restClient.GET();
            await taskGET.ContinueWith(antecedent => antecedent.Result));

            Task<string> taskCabecalho = RESTClient.GetCabecalho();
            //solicitando dados de cabeçalho
            string cabecalho = await taskCabecalho;

            Task<string> taskCorpo = RESTClient.GetCorpo();
            //solicitando dados de resposta
            string corpo = await taskCorpo;
            
            //atualizando lista de retorno de cabecalho na tela
            if (!String.IsNullOrEmpty(cabecalho))
                lstbxRespostaCabecalho.Items.Add(cabecalho);

            //atualizando lista de retorno de resposta na tela
            if (!String.IsNullOrEmpty(corpo))
                lstbxRespostaCorpo.Items.Add(corpo);
        }

        private void btnNovaRequisicao_Click(object sender, EventArgs e)
        {
            cbbxMetodoRequisicao.SelectedIndex = -1;
            cbbxUri.SelectedIndex = -1;
            cbbxTipoConteudo.SelectedIndex = -1;
            cbbbxRecurso.SelectedIndex = -1;
            lstbxRequisicaoCorpo.Items.Clear();
            lstbxRespostaCabecalho.Items.Clear();
            lstbxRespostaCorpo.Items.Clear();
        }
    }
}
