using CalendarioFeriados.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

//Foi utilizado os seguinte pacote: Newtonsoft
namespace CalendarioFeriados.Services
{
    public class ApiCaledarioService
    {
        //Estou utilizando a api https://api.calendario.com.br
        //está api tem a limitação de pesquisa de 5 cidades por token,
        //solicite seu token diretamente no site.

        //Url da api
        string url = "https://api.calendario.com.br/?";

        //Insira aqui o seu token
        string token = "amFyZGVsbC5vbGl2ZWlyYUBob3RtYWlsLmNvbSZoYXNoPTEzMjI2MjEwMg";
        public async Task<List<Events>> ConsultaFeriadosAsync(string codIBGE,string ano)
        {
            try
            {
                //Solicitação
                var UrlConsulta = $"{url}json=true&ano={ano}&ibge={codIBGE}&token={token}";

                //Enviar solicitação
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage httpResponse =  httpClient.GetAsync(UrlConsulta).Result;

                if (httpResponse.IsSuccessStatusCode)
                {
                    HttpContent httpContent = httpResponse.Content;

                    var result = await  httpContent.ReadAsStringAsync();

                    if(!result.Contains("Codigo IBGE invalido!"))
                    {
                        List<Events> events = JsonConvert.DeserializeObject<List<Events>>(result);
                        return events;
                    }
                    else
                    {
                        return null;
                    }


                }
                else
                {
                    return null;
                }

                
               
            }
            catch (JsonException e)
            {

                throw new JsonException(e.Message);
            }
        }
    }
}
