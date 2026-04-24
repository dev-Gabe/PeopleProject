using static PeopleProject.Functions.Funcoes;
using static PeopleProject.PeopleData.PeopleData;
using static PeopleProject.Validate.Validate;

namespace PeopleProject.Register;

public class RegisterPeople{
    public static void RegisterPP(){
        Clear();
        People p = new People(); //Cria uma nova pessoa no dicionário

        WriteText("Digite o seu nome\n\n\n=====> ");
        p.Nome = Console.ReadLine();

        Clear();
        WriteText("Digite a sua cidade\n\n\n=====> ");
        p.Cidade = Console.ReadLine();

        bool verified = false;
        string age;
        Clear();

        while (!verified)
        {
            WriteText("Digite o sua idade\n\n\n=====> ");
            //Validate age
            age = Console.ReadLine();
            verified = ValidateAge(age);
            if(verified == true){
                p.Idade = int.Parse(age);
            }
        }

        verified = false;
        string cpf;
        Clear();

        while (!verified){
            WriteText("Digite o seu CPF\n\n\n=====> ");
            cpf = Console.ReadLine();
            verified = ValidateCPF(cpf);
            if(verified == true){
                p.CPF = cpf;
                banco.Add(p.CPF, p);
            }
        }

    }
}