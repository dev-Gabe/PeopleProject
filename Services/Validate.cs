using static PeopleProject.Functions.Funcoes;

namespace PeopleProject.Validate;

public class Validate
{
    public static bool ValidateChoose(string option) //Valida as opções do menu
    {
        if (!int.TryParse(option, out int numero)){
            return false;
        }   
        else{
        return numero >= 1 && numero <= 4;
        }
    }

    public static bool ValidateCPF(string in_cpf){ //valida o cpf na consulta e no cadastro
        if(!long.TryParse(in_cpf, out _) || in_cpf.Length != 11){
            Clear();
            WriteText("O CPF deve ser um número, e deve conter 11 Dígitos. Tente novamente!\n");
            return false;
        }
        else
        {
                string choose;
                string formatedCPF;
                bool valChoose = false;
    
                while(!valChoose){
                    Clear();
                    formatedCPF = FormatCPF(in_cpf);
                    WriteText("O cpf está correto?\n" + formatedCPF + "\n1) Sim\n2) Não");
                    WriteText("\n\n\n=====> ");
                    choose = Console.ReadLine();
                        if((int.Parse(choose) >= 1) || (int.Parse(choose) <= 2)){
                            valChoose = ValidateChoose(choose);
                        }
                        else
                        {
                            return false;
                        }
                    
                    switch (int.Parse(choose))
                    {
                        case 1:
                        return true;
                        break;
                        
                        case 2:
                        Clear();
                        return false;
                        break;
                    }
                }
        }
        return false;
    }

    public static bool ValidateAge(string in_age){
        if(!int.TryParse(in_age, out int out_age) || out_age <= 0 || out_age > 110){
            Clear();
            WriteText("A idade deve ser um número, também deve ser maior que 0 e menor que 110. Tente novamente!\n");
            return false;
        }
        else
        {
            return true;
        }
    }
}