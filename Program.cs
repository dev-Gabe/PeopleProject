using static PeopleProject.Validate.Validate;
using static PeopleProject.Functions.Funcoes;
using static PeopleProject.PeopleData.PeopleData;
using static PeopleProject.Register.RegisterPeople;
using static PeopleProject.ConsultP.Consultar;
using static PeopleProject.Delete.Deletar;

// Estou usando Layered Architecture
namespace PeopleProject;
public class Program{

    public static void Main()
    {
        bool isValid = false; // Faz o programa rodar, enquanto ele for False irá rodar o programa
        string option = ""; //limpo a variável, e declaro ela globalmente dentro do escopo do main

        while(!isValid){
            Clear();
            WriteLText("====================== BEM VINDO AO NOSSO SISTEMA DE PESSOAS ======================");
            WriteText("SELECIONE UMA OPÇÃO ABAIXO: ");
            WriteText("\n1) Consultar CPF\n2) Cadastrar CPF\n3) Deletar CPF\n4) Sair\n");
            WriteText("=====> "); 
                option = Console.ReadLine();
                isValid = ValidateChoose(option);
        }

        //Aqui o menu funciona de verdade
        switch (int.Parse(option))
        {
            case 1:
            //Consult
            Clear();
            Consult();
            Main();
            break;

            case 2:
            //Cadastro
            Clear();
            RegisterPP();
            Main();
            break;

            case 3:
            //Delete
            Clear();
            DeleT();
            Main();
            break;

            case 4:
            //End
            break;
            
        };
    }
}
