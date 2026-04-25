using static PeopleProject.Functions.Funcoes;
using static PeopleProject.Validate.Validate;
using static PeopleProject.PeopleData.PeopleData;

namespace PeopleProject.Delete;

public class Deletar{
    public static void DeleT(){
        bool delete_on = false;
        string cpf = "";
        Clear();

            while(!delete_on){
                WriteLText("Digite o CPF que deseja Deletar");
                WriteText("=====> ");
                cpf = Console.ReadLine();
                delete_on = ValidateCPF(cpf);
            }

            if (banco.ContainsKey(cpf)){
            var p = banco[cpf];
            Clear();
            bool isValid = false;

            while(!isValid){
                WriteText("Pessoa Encontrada!\n\nDeseja deletar o cpf [" + FormatCPF(p.CPF) + "]?");
                WriteText("\n\n\n1)Sim  2)Não\n=====> ");
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
                          //DELETA O CPF
                          banco.Remove(cpf);
                          isValid = true;
                          Clear();
                          WriteText("Pessoa deletada do nosso banco com sucesso!!\n\nPara retornar ao menu principal, aperte enter.");
                          Console.ReadLine();
                        } else if(choose == "2"){
                            isValid = true;
                        }
                    }
                }
            }
                else{
                //ERRO AO DELETAR
                Clear();
                bool isValid = false;

                while(!isValid){
                WriteText("Pessoa não encontrada!\n\nDeseja retornar ou tentar novamente?");
                WriteText("\n\n\n1)Tentar Novamente  2)Retornar\n=====> ");
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
                          //RETORNA
                          DeleT();
                        } else if(choose == "2"){
                            isValid = true;
                        }
                        }
                    }
                }
    }
    
}