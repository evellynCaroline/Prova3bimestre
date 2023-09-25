using Prova_Terceiro_Bimestre.Classes;
using System;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(" Digite : \n 0- Para Sair \n 1- Cadastrar usuário");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1) 
            {
                Console.WriteLine("Otimo! Digite \n 0- Para sair \n 1- Funcionario \n 2- Medico \n 3- Funcionario Administrativo");
                int opcao1 = Convert.ToInt32(Console.ReadLine());

                if (opcao1 == 1) 
                {
                    List <string> fun = new List<string>(); 

                    Funcionario funcionario = new Funcionario();

                    Console.WriteLine("Nos informe seu Nome: ");
                    //fun.Add(Console.ReadLine());
                    funcionario.Nome = Console.ReadLine();
                    fun.Add(funcionario.Nome);

                    Console.WriteLine("Nos informe seu Cpf: ");
                    funcionario.Cpf = Console.ReadLine();
                    fun.Add (funcionario.Cpf);

                    Console.WriteLine("Nos informe sua Matricula: ");
                    funcionario.Matricula = Console.ReadLine();   
                    fun.Add(funcionario.Matricula);

                    Console.WriteLine("Nos informe sua Data de Nascimento: ");
                    funcionario.DataNasc = Console.ReadLine();
                    fun.Add(funcionario.DataNasc);

                    Console.WriteLine("Nos informe seu Sexo: ");
                    funcionario.Sexo = Console.ReadLine();
                    fun.Add(funcionario.Sexo);




                    Console.WriteLine("Seus dados foram salvos!");

                    foreach (string item in fun) 
                    {
                        Console.WriteLine(item.ToString());
                    }

                    Console.WriteLine("Seu salário" + funcionario.Nome + "é de " + funcionario.Salario);

                }

                else if (opcao1 == 2)
                {
                    List<string> fun1 = new List<string>();

                    Funcionario funcionario1 = new Funcionario();

                    Console.WriteLine("Nos informe seu Nome: ");
                    //fun.Add(Console.ReadLine());
                    funcionario1.Nome = Console.ReadLine();
                    fun1.Add(funcionario1.Nome);

                    Console.WriteLine("Nos informe seu Cpf: ");
                    funcionario1.Cpf = Console.ReadLine();
                    fun1.Add(funcionario1.Cpf);

                    Console.WriteLine("Nos informe sua Matricula: ");
                    funcionario1.Matricula = Console.ReadLine();
                    fun1.Add(funcionario1.Matricula);

                    Console.WriteLine("Nos informe sua Data de Nascimento: ");
                    funcionario1.DataNasc = Console.ReadLine();
                    fun1.Add(funcionario1.DataNasc);

                    Console.WriteLine("Nos informe seu Sexo: ");
                    funcionario1.Sexo = Console.ReadLine();
                    fun1.Add(funcionario1.Sexo);

                    fun1.Add(funcionario1.Salario);



                    Console.WriteLine("Seus dados foram salvos!");

                    foreach (string item in fun1)
                    {
                        Console.WriteLine(item.ToString());
                    }

                    Console.WriteLine("Seu salário" + funcionario1.Nome + "é de " + funcionario1.Salario);

                }

                else if (opcao1 == 3)
                {
                    List<string> fun2 = new List<string>();

                    Funcionario funcionario2 = new Funcionario();

                    Console.WriteLine("Nos informe seu Nome: ");
                    //fun.Add(Console.ReadLine());
                    funcionario2.Nome = Console.ReadLine();
                    fun2.Add(funcionario2.Nome);

                    Console.WriteLine("Nos informe seu Cpf: ");
                    funcionario2.Cpf = Console.ReadLine();
                    fun2.Add(funcionario2.Cpf);

                    Console.WriteLine("Nos informe sua Matricula: ");
                    funcionario2.Matricula = Console.ReadLine();
                    fun2.Add(funcionario2.Matricula);

                    Console.WriteLine("Nos informe sua Data de Nascimento: ");
                    funcionario2.DataNasc = Console.ReadLine();
                    fun2.Add(funcionario2.DataNasc);

                    Console.WriteLine("Nos informe seu Sexo: ");
                    funcionario2.Sexo = Console.ReadLine();
                    fun2.Add(funcionario2.Sexo);

                    fun2.Add(funcionario2.Salario);



                    Console.WriteLine("Seus dados foram salvos!");

                    foreach (string item in fun2)
                    {
                        Console.WriteLine(item.ToString());
                    }

                    Console.WriteLine("Seu salário" + funcionario2.Nome + "é de " + funcionario2.Salario);
                }

            }
            else if (opcao == 0)
            { 
                
            }
                
           



        }
        catch 
        {
            Console.WriteLine("Algo deu errado!");
        }
        
    }   
}