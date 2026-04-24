using static PeopleProject.Functions.Funcoes;
using static PeopleProject.Validate.Validate;
using static PeopleProject.PeopleData.PeopleData;

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

        if (banco.ContainsKey(cpf)){
            var p = banco[cpf];
            Clear();

            WriteText("Pessoa Encontrada!\n\n");
            WriteText("=============== NOME ===============\n" + p.Nome);
            WriteText("\n============== IDADE  ==============\n" + p.Idade);
            WriteText("\n================ CPF ===============\n" + p.CPF);
            WriteText("\n============== CIDADE ==============\n" + p.Cidade);
        }
        else
        {
            Clear();
            bool isValid = false;

                while(!isValid){
                WriteText("CPF não encontrado. Tente novamente ou volte para o menu principal.\n\n1)Tente Novamente\n2)Voltar ao menu");
                WriteText("\n\n\n=====> ");
                string choose;
                choose = Console.ReadLine();
                isValid = ValidateChoose(choose);
                Clear();
                    if (isValid == true){
                        if (choose != "1" && choose != "2")
                        {
                            Clear();
                            WriteText("Use somente a opção 1 ou 2!\n\n");
                            isValid = false;
                        }
                        
                        if(choose == "1"){
                            Consult();
                        } else if(choose == "2"){
                            isValid = true;
                        }
                    }
                }


        }
    }
}