using System.Dynamic;
using System.Text.Json;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Rest
{
    public class BrasilAPIRest : IBrasilApi
    {
        public async Task<ResponseGeneric<EnderecoModel>> BuscarEnderecoPorCEP(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,  $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseGeneric<EnderecoModel>();
            using(var client = new HttpClient()){
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode){
                    response.codigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }else{
                    response.codigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }
        public async Task<ResponseGeneric<List<BancoModel>>> BuscarTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,  $"https://brasilapi.com.br/api/banks/v1");

            var response = new ResponseGeneric<List<BancoModel>>();
            using(var client = new HttpClient()){
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode){
                    response.codigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }else{
                    response.codigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }
        public async Task<ResponseGeneric<BancoModel>> BuscarBanco(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,  $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");

            var response = new ResponseGeneric<BancoModel>();
            using(var client = new HttpClient()){
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<BancoModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode){
                    response.codigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }else{
                    response.codigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }

    }
}