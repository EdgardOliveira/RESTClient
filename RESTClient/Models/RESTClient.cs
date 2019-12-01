using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RESTClient
{
    class RESTClient
    {
        /// <summary>
        /// Tipo enumerado com os métodos de requisição
        /// </summary>
        public enum TipoMetodo
        {
            GET     = 1,
            POST    = 2,
            PUT     = 3,
            DELETE  = 4,
            PATCH   = 5
        }

        /// <summary>
        /// Atributos
        /// </summary>
        /// 
        public string baseUri { get; set; }
        public string recurso { get; set; }
        public TipoMetodo tipoMetodo { get; set; }
        public string tipoConteudo { get; set; }
        public string corpo { get; private set; }
        public string cabecalho { get; private set; }
        public HttpClient httpClient {get; private set; }
        
        /// <summary>
        /// Construtor vazio... possibilita instanciar sem passar parâmetros
        /// </summary>
        public RESTClient()
        {

        }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="tipoMetodo"></param>
        /// <param name="tipoConteudo"></param>
        public RESTClient(string baseUri, string recurso, TipoMetodo tipoMetodo, string tipoConteudo=null, string corpo=null)
        {
            this.baseUri = baseUri;
            this.recurso = recurso;
            this.tipoMetodo = tipoMetodo;
            this.tipoConteudo = tipoConteudo;
            this.corpo = corpo;
            this.httpClient = new HttpClient();

            Console.WriteLine("Endpoint: {0}{1}\nTipo de Requisição:{2}\nTipo de Conteúdo: {3}\n", baseUri, recurso, tipoMetodo, tipoConteudo);
            
            //chamando a configuração no construtor
            RESTConfigAsync();
        }
        /// <summary>
        /// Método para solicitar requisições
        /// </summary>
        /// <returns></returns>
        public async Task GET()
        {
            Console.WriteLine("Foi solicitado a requisição de dados - GET...");
            await GetDadosAsync();
        }

        /// <summary>
        /// Método para postar requisições
        /// </summary>
        /// <returns></returns>
        public async Task POST()
        {
            Console.WriteLine("Foi solicitado o envio de dados - POST...");
            await PostDadosAsync();
        }

        /// <summary>
        /// Método para atualizar requisições
        /// </summary>
        /// <returns></returns>
        public async Task PUT()
        {
            Console.WriteLine("Foi solicitado o envio de alteração de dados - PUT...");
            await PutDadosAsync();
        }

        /// <summary>
        /// Método para apagar requisições
        /// </summary>
        /// <returns></returns>
        public async Task DELETE()
        {
            Console.WriteLine("Foi solicitado a remoção de dados - DELETE...");
            await DeleteDadosAsync();
        }
        /// <summary>
        /// Método para atualizar recursos sem enviar todos os dados
        /// </summary>
        /// <returns></returns>
        public async Task PATCH()
        {
            Console.WriteLine("Foi solicitado o envio de alteração de dados - PATCH...");
            await PatchDadosAsync();
        }

        /// <summary>
        /// Método para configurar requisições
        /// </summary>
        /// <returns></returns>
        private async Task RESTConfigAsync()
        {
            Console.WriteLine("Foi solicitada a configuração do RESTClient...");
            //configurando o endereço do servidor
            httpClient.BaseAddress = new Uri(baseUri);
            //limpando o cabeçalho
            httpClient.DefaultRequestHeaders.Accept.Clear();
            //configurando o tipo de conteúdo de dados
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(tipoConteudo));
        }

        /// <summary>
        /// Método para configurar requisições GET
        /// </summary>
        /// <returns></returns>
        private async Task GetDadosAsync()
        {
            //inicializando
            corpo = null;
            cabecalho = null;
            Console.WriteLine("Foi solicitada a requisição GET de dados de forma assíncrona...");
            //solicitando a requisição
            HttpResponseMessage response = await httpClient.GetAsync(recurso);

            await TratarResposta(response);
        }

        /// <summary>
        /// Método para configurar requisições POST
        /// </summary>
        /// <returns></returns>
        private async Task PostDadosAsync()
        {
            var stringContent = new StringContent(corpo, UnicodeEncoding.UTF8, "application/json");
            Console.WriteLine("Foi solicitada a requisição POST de dados de forma assíncrona...");
            HttpResponseMessage response = await httpClient.PostAsync(recurso, stringContent);

            await TratarResposta(response);
        }

        /// <summary>
        /// Método para configurar atualizações PUT
        /// </summary>
        /// <returns></returns>
        private async Task PutDadosAsync()
        {
            var stringContent = new StringContent(corpo, UnicodeEncoding.UTF8, "application/json");
            Console.WriteLine("Foi solicitada a requisição PUT de dados de forma assíncrona..."); 
            HttpResponseMessage response = await httpClient.PutAsync(recurso, stringContent);
            
            await TratarResposta(response);
        }

        /// <summary>
        /// Método para configurar requisições DELETE
        /// </summary>
        /// <returns></returns>
        private async Task DeleteDadosAsync()
        {
            Console.WriteLine("Foi solicitada a requisição DELETE de dados de forma assíncrona..."); 
            HttpResponseMessage response = await httpClient.DeleteAsync(recurso);

            await TratarResposta(response);
        }

        private async Task PatchDadosAsync()
        {
            //TODO a ser implementado
            Console.WriteLine("Método patch ainda não implementado neste RESTClient.");
        }

        /// <summary>
        /// Método para tratar respostas
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private async Task TratarResposta(HttpResponseMessage response)
        {
            Console.WriteLine("Foi solicitada o tratamento das respostas de dados de forma assíncrona...");
            //armazenando a resposta
            cabecalho = response.ToString();
            Console.WriteLine("Header:{0}", cabecalho);

            //verificando se a resposta do servidor foi OK
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Status: {0}", response.StatusCode);
                //fazendo a leitura do conteúdo da resposta de forma assíncrona
                var json = await response.Content.ReadAsStringAsync();

                //armazenando o conteudo da resposta (corpo)
                corpo = json.ToString();
                Console.WriteLine("Body: {0}", corpo);
            }
        }
    }
}
