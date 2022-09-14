using ProjetoAprendizado;
using System;
using System.Collections.Concurrent;

namespace ProjetoAprendizadp{

    class Program{

        enum Opcoes1 { Registrar = 1, Entrar, Encerrar}
        static Bank Conta = new Bank();


        static void Main() 
        {
            Console.WriteLine("V1.1.0");
            bool WhileConsoleTrue = true;

            while (WhileConsoleTrue == true)
            {
                Console.Write("\nEscolha uma opção: \n\n -(1) Registrar\n -(2) Entrar\n -(3) Sair\n\n >> ");
                int opc = int.Parse(Console.ReadLine());

                Opcoes1 Menu = (Opcoes1)opc;
                WhileConsoleTrue = ControlMenu((int)Menu);
            }


            Console.WriteLine($"\n -- fim do programa : Obrigado por executar!! --");
            Console.ReadLine();
        }

        static bool ControlMenu(int aba) // essa função controla o menu ->
        {
            
            switch (aba)
            {
                case 1:
                    Console.Clear();
                    LoginFunc();
                    return true;
                    break;

                case 2:
                    Console.Clear();
                    return EntrarFunc();
                    break;

                case 3:
                    return false;
                    break;

                default:
                    Console.WriteLine("!! >> (Comando não reconhecido pelo sistema, tente uma das opções Abaixo: << !!");
                    return true;
                    break;
            }

        }

        static bool EntrarFunc() // função de entrada da conta -> 
        {
            Console.Clear ();
            Console.Write("-- Login --\n\nNome Da Conta: "); 
            string nome = Console.ReadLine(); // pega o nome da classe Bank em Class1

            Console.Write("\nDigite sua senha: ");
            string senha = Console.ReadLine (); // pega a senha da classe Bank em Class1

            // verificação se a senha esta correta, ou a conta é existente. -> 
            if (nome == Conta.nome && senha == Conta.senha) 
            { 
                Console.Clear(); 
                Console.WriteLine("-- Login Bem Sucedido!!!! --");

                Console.WriteLine("\nCodigo feito com um aprendizado de menos de 1 semana de C#" +
                    " ,espero que tenha gostado!!  \n ~~ Pedro Soares De Assis  V 1.1.0");

                return false;
            }

            else // se não existir ou a senha estiver errada ele volta pra pagina 1 (Opções)
            { 
                Console.Clear(); Console.WriteLine("!! >> Login inexistente ou incorreto<< !!");
                return true; 
            }

        }

        static void LoginFunc() // Função de lingin de novo usuario ->
        {
            Console.Clear ();
            bool CodeOn = true;

            string senha;
            string ConfirmSenha;
            string nome;

            while (CodeOn == true) {

                Console.Write("-- Registrando --\n\nDigite seu nome: ");
                nome = Console.ReadLine();

                Console.Write("\nDigite uma senha: ");
                senha = Console.ReadLine();

                Console.Write("\nConfirmar Senha : ");
                ConfirmSenha = Console.ReadLine();

                if (senha == ConfirmSenha)
                {

                    Conta.nome = nome;
                    Conta.senha = senha;

                    Console.Clear();
                    Console.WriteLine("-- Conta criada com sucesso !! --");

                    CodeOn = false;
                }

                else 
                { 
                    Console.Clear(); Console.WriteLine("Senha não se conhecidem ! Tente novamente"); 
                }

            }

        }

    }

}