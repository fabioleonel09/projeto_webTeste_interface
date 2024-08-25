using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webTesteInterface.Classes_API.Exames;

namespace webTesteInterface
{
    public partial class _Default : Page
    {
        #region VARIAVEIS GERAIS
        HttpClient client;
        Uri usuarioUri;
        #endregion

        public _Default()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44352/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getAll();
            }
        }

        private void getAll()
        {
            //Chamando a API pela URL
            System.Net.Http.HttpResponseMessage response = client.GetAsync("api/tabelaPacientes").Result;

            //Se retornar sucesso na busca dos dados
            if (response.IsSuccessStatusCode)
            {
                //monta o cabeçalho
                usuarioUri = response.Headers.Location;

                //pega os dados do Rest
                var pacientes = response.Content.ReadAsAsync<IEnumerable<tabelaPacientes>>().Result;

                //preenchendo a lista com os dados
                gdvInicial.DataSource = pacientes;
                gdvInicial.DataBind();
            }
            else
            {
                //se der erro, mostra o status
                Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
            }
        }
    }
}