using ProjetoAprendizado;
using System;
using System.Collections.Concurrent;

namespace ProjetoAprendizadp{

    class Program{

        enum Opcoes1 { Registrar = 1, Entrar, Encerrar}

        static Bank Conta = new Bank();


        static void Main() 
        {

            bool WhileConsoleTrue = true;

            while (WhileConsoleTrue == true)
            {
                Console.Write("\nEscolha uma opção: \n\n -(1) Registrar\n -(2) Entrar\n -(3) Sair\n\n >> ");
                int opc = int.Parse(Console.ReadLine());

                Opcoes1 Menu = (Opcoes1)opc;
                WhileConsoleTrue = ControlMenu((int)Menu);
            }


            Console.WriteLine("\n                      fim do programa : Obrigado por executar!!");

        }

        static bool ControlMenu(int aba)
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
                    EntrarFunc();
                    return true;
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

        static void EntrarFunc()
        {
            Console.Clear ();
            Console.Write("-- Login --\n\nNome Da Conta: ");
            string nome = Console.ReadLine();

            Console.Write("\nDigite sua senha: ");
            string senha = Console.ReadLine ();

            if(nome == Conta.nome && senha == Conta.senha) 
            { 
                Console.Clear(); 
                Console.WriteLine("-- Login Bem Sucedido!!!! --");

                Console.WriteLine("Codigo feito com um aprendizado de menos de 1 semana de C#" +
                    " ,espero que tenha gostado!!   ~~ Pedro Soares De Assis  V 1.0.0");
            }
            else { Console.Clear(); Console.WriteLine("!! >> Login inexistente ou errado << !!"); }

        }

        static void LoginFunc()
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