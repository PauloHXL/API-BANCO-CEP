using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGeneric<EnderecoResponse>> BuscarEndereco(string cep);
    }
}