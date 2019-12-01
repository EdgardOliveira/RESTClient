using Newtonsoft.Json;
using RESTClient.Models;
using System;
using System.Windows.Forms;
namespace RESTClient
{
    public partial class frmPrincipal : Form
    {
        private RESTClient restClient;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private bool ValidarDados()
        {
            bool status = true;

            if (cbbxMetodoRequisicao.SelectedIndex == -1)
                status = false;

            if (cbbxUri.SelectedIndex == -1)
                status = false;

            if (cbbxTipoConteudo.SelectedIndex == -1)
                status = false;

            if (cbbbxRecurso.SelectedIndex == -1)
                status = false;

            return status;
        }

        private async void btnEnviar_ClickAsync(object sender, EventArgs e)
        {
            if (ValidarDados()){
                RESTClient.TipoMetodo tipoMetodo = 0;
                string corpo = null;
                string tipoConteudo = null;
                int indiceMetodoRequisicao = cbbxMetodoRequisicao.SelectedIndex + 1;
                int indiceTipoConteudo = cbbxTipoConteudo.SelectedIndex;

                //verificando o tipo de requisição
                if (indiceMetodoRequisicao != -1)
                    tipoMetodo = (RESTClient.TipoMetodo)indiceMetodoRequisicao;

                //verificando o tipo de conteúdo
                if (indiceTipoConteudo != -1)
                    tipoConteudo = (string)cbbxTipoConteudo.SelectedItem;

                Atendente atendente = new Atendente()
                {
                    id = 0,
                    name = "teste de post",
                    card = "asdadqw123123123"
                };

                corpo = JsonConvert.SerializeObject(atendente);

                //Instanciando a classe e passando parâmetros no construtor
                restClient = new RESTClient(cbbxUri.Text, cbbbxRecurso.Text, tipoMetodo, tipoConteudo, corpo);

                switch (tipoMetodo)
                {
                    case RESTClient.TipoMetodo.GET:
                        await restClient.GET();
                        break;
                    case RESTClient.TipoMetodo.POST:
                        await restClient.POST();
                        break;
                    case RESTClient.TipoMetodo.PUT:
                        await restClient.PUT();
                        break;
                    case RESTClient.TipoMetodo.DELETE:
                        await restClient.DELETE();
                        break;
                    case RESTClient.TipoMetodo.PATCH:
                        await restClient.PATCH();
                        break;
                }
                AtualizarResposta();
            }
            else
            {
                MessageBox.Show("Configure os dados de forma apropriada!", "Preencha os parâmetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void AtualizarResposta()
        {
            lstbxRespostaCabecalho.Items.Clear();
            lstbxRespostaCabecalho.Items.Add(restClient.cabecalho);

            lstbxRespostaCorpo.Items.Clear();
            lstbxRespostaCorpo.Items.Add(restClient.corpo);

            tbctrResposta.SelectedTab = tbpgCorpo;
        }

        private void cbbxMetodoRequisicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbxMetodoRequisicao.SelectedItem.Equals("GET"))
                lstbxRequisicaoCorpo.Enabled = false;
            else
                lstbxRequisicaoCorpo.Enabled = true;
        }
    }
}
