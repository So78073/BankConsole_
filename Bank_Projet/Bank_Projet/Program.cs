using System;
using System.Collections.Generic;


namespace PaginaPrincipal
{
    class Program
    {

        static Dictionary<int, string> Nome_ = new Dictionary<int, string>() { [7777] = "PedroS"};
        static Dictionary<int, string> Senha_ = new Dictionary<int, string>() { [7777] = "1235378"}; 
        static Dictionary<int, float> Saldo_ = new Dictionary<int, float>() { [7777] = 100.00f}; 

        static bool WhiLoop = true;

        static int AcountAtive;
        static string Page = "init";
        static void Main() 
        { 

            while(WhiLoop == true)
            {
                if (Page == "init")
                {
                    Console.Write("V2.0.0\n");

                    Console.Write("\n -- wellcome to BankSole --\n\n " +
                        "(1) Register \n " +
                        "(2) Login \n " +
                        "(3) Shutting down\n\n >>  ");

                    int num = int.Parse(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            Register();
                            break;

                        case 2:
                            Login();

                            break;
                        case 3:
                            WhiLoop = false;
                            break;

                        default:
                            Console.Clear();
                            Console.Write(" !! Command not exist !! - ");
                            break;

                    }

                }

                if (Page == "user")
                {
                    Console.WriteLine("\n\n -- User: {0}      N* {1}      Balance --> {2}\n", Nome_[AcountAtive],
                    AcountAtive, Saldo_[AcountAtive]);

                    Console.Write(" (1) deposit\n (2) Close\n\n >>  ");
                    int n1 = int.Parse(Console.ReadLine());

                    switch (n1)
                    {
                        case 1:
                            Deposit();
                            break;

                        case 2:
                            Page = "init";
                            AcountAtive = 0000;
                            Console.Clear();
                            break;

                        default:
                            Console.Clear();
                            Console.Write(" !! Command not exist !! - ");
                            break;

                    }

                }
            }
            Console.WriteLine("\n\nEnd Of Program , Thanks for Downloarding !! you have permision " +
                "to create new functions !!\n\n\n\n");
        }

        //FUNCs ============================================================================================

        static void Register()
        {
            Console.Clear();
            int Key;
            string Name;
            string Password;
            string PassowrdConfirm;

            bool Wloop2 = true;

            while (Wloop2 == true)
            {
                Console.Write("-- Register New Acount --\n\n");

                Console.Write(" / Access Key(0000): ");
                Key = int.Parse(Console.ReadLine());

                if (Key > 1000 && Key < 9999) 
                { 
                    Console.Write("\n / Your name: ");
                    Name = Console.ReadLine();

                    Console.Write("\n / Password: ");
                    Password = Console.ReadLine();

                    Console.Write("\n / Confirm password: ");
                    PassowrdConfirm = Console.ReadLine();

                    if(Password == PassowrdConfirm)
                    {
                        Nome_.Add(Key, Name);
                        Senha_.Add(Key, Password);
                        Saldo_.Add(Key, 100);

                        Console.Clear();
                        Console.Write("-- Create acount with success --");
                        Wloop2 = false;
                    }
                    else { Console.Clear();  Console.Write("--! passwords are not the same "); }

                }
                else { Console.Clear();  Console.Write("--! invalid Key "); }
            }



        }
    
        static void Login()
        {
            Console.Clear();
            int Key;
            string Name;
            string Password;

            bool Wloop3 = true;

            while(Wloop3 == true)
            {
                Console.Write("-- Login Page --\n");

                Console.Write("\n / Key Acount: ");
                Key = int.Parse(Console.ReadLine());

                if(Key > 1000 && Key < 9999)
                {
                    if (Nome_.ContainsKey(Key))
                    {
                        Console.Write("\n / Name: ");
                        Name = Console.ReadLine();

                        Console.Write("\n / Passworld: ");
                        Password = Console.ReadLine();

                        if (Nome_[Key] == Name)
                        {
                            if (Senha_[Key] == Password)
                            {
                                Console.Clear();
                                Console.Write("-- Login successfully accessed --");
                                AcountAtive = Key;
                                Page = "user";
                                Console.Clear();
                                Wloop3 = false;
                            }
                            else { Console.Clear(); Console.Write(" -- incorret password "); }
                        }
                        else { Console.Clear(); Console.Write(" -- Acount not found "); }
                    }
                    else { Console.Clear(); Console.Write(" -- Key not exist "); }
                }
                else
                { 
                  Console.Clear(); 
                  Console.Write("-- invallid Key "); 
                }



            }
        }

        static void Deposit()
        {
            bool Wloop = true;

            float Money;
            int People;
            Console.Clear();
            while (Wloop == true)
            {
                Console.Write("-- Deposit --");

                Console.Write("\n\n To (Key Code): ");
                People = int.Parse(Console.ReadLine());

                Console.Write("\n How Much ?: ");
                Money = float.Parse(Console.ReadLine());

                

                if (People > 1000 && People < 9999)
                {
                    if (Saldo_[AcountAtive] - Money >= 0)
                    {
                        float NewSaldo = Saldo_[AcountAtive] - Money;
                        Saldo_.Remove(AcountAtive);
                        Saldo_.Add(AcountAtive, NewSaldo);

                        Console.Clear();
                        Console.Write(" -- transfer completed ");
                        Wloop = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write(" -- Dinheiro insuficiente ");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write(" -- Invalid Key ");
                }
            }
                
        }
    }
}