using static PeopleProject.Functions.Funcoes;
using static PeopleProject.Validate.Validate;

namespace PeopleProject.PeopleData;

public class PeopleData
{
    public struct People{
        public string Nome{ get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; } //tive que transformar o CPF em string pq ele nao cabe em um int kkkkkkk
        public string Cidade{ get; set; }
    };
    public static Dictionary<string, People> banco = new();
}