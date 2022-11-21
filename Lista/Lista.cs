using Pro.Listas;
namespace Pro.Listas;
class Program
{
    static void Main(string[] args)
    {

        var CadastroDeUsuáriosETransações = new List<ListaDeUsuáriosETransaçõesCadastradas>()
             {
              new ListaDeUsuáriosETransaçõesCadastradas { Id = 1, NomeCompleto = "Brayan", Idade = 27, Cpf = 123456789 },
              new ListaDeUsuáriosETransaçõesCadastradas { Id = 2, NomeCompleto = "Larissa", Idade = 28, Cpf = 789456123 },
              new ListaDeUsuáriosETransaçõesCadastradas { Id = 3, NomeCompleto = "Clara", Idade = 32, Cpf = 321654987 },
              new ListaDeUsuáriosETransaçõesCadastradas { Id = 4, NomeCompleto = "Roberto", Idade = 35, Cpf = 654987321 },
              new ListaDeUsuáriosETransaçõesCadastradas{  Id = 5, NomeCompleto = "Roberta", Idade = 35, Cpf = 654987321 },

              new ListaDeUsuáriosETransaçõesCadastradas { Id = 6, Valor = 1000, Tipo = "TED", DataDaTransação = 14 / 11 / 2022, Devedor = "Larissa", Credor = "Brayan" },
              new ListaDeUsuáriosETransaçõesCadastradas { Id = 7, Valor = 200, Tipo = "DOC", DataDaTransação = 15 / 11 / 2022, Devedor = "Clara", Credor = "Larissa" },
              new ListaDeUsuáriosETransaçõesCadastradas { Id = 8, Valor = 300, Tipo = "DOC", DataDaTransação = 15 / 11 / 2022, Devedor = "Roberto", Credor = "Clara" },
              new ListaDeUsuáriosETransaçõesCadastradas { Id = 9, Valor = 400, Tipo = "TED", DataDaTransação = 15 / 11 / 2022, Devedor = "Roberta", Credor = "Roberto" },
              new ListaDeUsuáriosETransaçõesCadastradas { Id = 10,Valor = 500, Tipo = "DOC", DataDaTransação = 15 / 11 / 2022, Devedor = "Brayan", Credor = "Roberta" }
             };

    }
}