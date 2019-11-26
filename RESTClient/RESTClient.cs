using System;
using System.Net.Http;
using System.Net.Http.Headers;
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
            UPDATE  = 3,
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
        public static string corpo { get; private set; }
        public static string cabecalho { get; private set; }
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
        public RESTClient(string baseUri, string recurso, int tipoMetodo, string tipoConteudo=null)
        {
            this.baseUri = baseUri;
            this.recurso = recurso;
            this.tipoMetodo = (TipoMetodo) tipoMetodo;
            this.tipoConteudo = tipoConteudo;
            this.httpClient = new HttpClient();
            RESTConfigAsync();
        }

        public async Task GET()
        {   
            GetDadosAsync();
        }

        private async Task RESTConfigAsync()
        {
            //configurando o endereço do servidor
            httpClient.BaseAddress = new Uri(baseUri);
            //limpando o cabeçalho
            httpClient.DefaultRequestHeaders.Accept.Clear();
            //configurando o tipo de conteúdo de dados
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(tipoConteudo));
        }

        private async Task GetDadosAsync()
        {
            //inicializando
            corpo = null;
            cabecalho = null;

            //solicitando a requisição
            HttpResponseMessage response = await httpClient.GetAsync(recurso);
            
            //armazenando a resposta
            cabecalho = response.ToString();
            Console.WriteLine("Header:\n" + cabecalho);

            //verificando se a resposta do servidor foi OK
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Status: " + response.StatusCode);
                //fazendo a leitura do conteúdo da resposta de forma assíncrona
                var json = await response.Content.ReadAsStringAsync();
                //armazenando o conteudo da resposta (corpo)
                corpo = json.ToString();
                Console.WriteLine("Body:\n" + corpo);
            }
        }

        public static async Task<string> GetCabecalho()
        {
            string retorno = $"Cabeçalho: {cabecalho:S}\n";
            Console.WriteLine(retorno);
            return cabecalho;
        }
        public static async Task<string> GetCorpo()
        {
            string retorno = $"Corpo: {corpo:S}\n";
            Console.WriteLine(retorno);
            return corpo;
        }
    }
}
