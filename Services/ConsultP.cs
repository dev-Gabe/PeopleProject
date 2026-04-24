using static PeopleProject.Functions.Funcoes;
using static PeopleProject.Validate.Validate;

namespace PeopleProject.ConsultP;

public class Consultar{
    public static void Consult(){
        bool consult_on = false;
        string cpf = "";
        Clear();

            while(!consult_on){
                WriteLText("Digite o CPF que deseja consultar");
                WriteText("=====> ");
                cpf = Console.ReadLine();
                consult_on = ValidateCPF(cpf);
            }
    }
}