using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGeneric<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGeneric<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGeneric<BancoModel>> BuscarBanco(string codigoBanco);
    }
}