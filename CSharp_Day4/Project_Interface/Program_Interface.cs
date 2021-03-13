using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Inheritence1
{
    interface manageAccount 
    {
        void openAccount();
        void closeAccount();
    }

    interface Accountdetails
    {
        void diposite();
        void withdraw();
        void display();
    }


    class Saving_Acount : manageAccount, Accountdetails
    {
        int userID;
        String username;
        String AccountSt;

        float DepoMoney, withdMoney, totalMoney;

        public Saving_Acount()
        {
        userID = 0 ;
        username ="NA";
        AccountSt = "NA";
        totalMoney = 0;
        DepoMoney = 0;
        withdMoney = 0;
         }

        public void openAccount() {

            try
            {
                Console.WriteLine("Enter the User id");
                userID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the User name");
                username = Console.ReadLine();
                AccountSt = "Created";
                Console.WriteLine("AccountStatus : " + AccountSt);
            }
            catch(Exception e) {
                Console.WriteLine(" Exception " + e);
            }
            finally
            {
            }

        }
        public void closeAccount() {

            try
            {
                Console.WriteLine("Enter the User id");
                userID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the User name");
                username = Console.ReadLine();
                AccountSt = "Closed";
                Console.WriteLine("AccountStatuc :" + AccountSt);
            }
            catch (Exception e)
            {
                Console.WriteLine(" Exception " + e);
            }
            finally 
            { 
            }
        }

        public void diposite() {
            Console.WriteLine("Please enter deposite Money");
            DepoMoney = float.Parse(Console.ReadLine());
            totalMoney = totalMoney + DepoMoney;

            Console.WriteLine("deposite Money" + DepoMoney);
            Console.WriteLine("totalMoney" + totalMoney);

        }
        public void withdraw() {
            Console.WriteLine("");
            
            Console.WriteLine("Please enter Withdraw money");

            withdMoney = float.Parse(Console.ReadLine());
            totalMoney = totalMoney - withdMoney;
            Console.WriteLine("withdraw Money" + withdMoney);
            Console.WriteLine("totalMoney" + totalMoney);

        }

        public void display() {
            Console.WriteLine("Display the user details");
        }
    }

    class Program_Bank
    {
        static void Main(string[] args)
        {
            int option =0;
            String response="no";

            Console.WriteLine("Bank- SBI");
            Console.WriteLine("---------------------------\n");
            Console.ReadKey();

            Saving_Acount SbiObj = new Saving_Acount();

            do
            {
                
                Console.WriteLine("Option : \n 1. for Account creation \n 2. for Account close \n 3. Deposite \n 4. withdraw \n 5. Display ");
                Console.WriteLine("\n---------------------------\n");
                Console.WriteLine("Please select the option ");
                
                try {

                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            SbiObj.openAccount();
                            break;
                        case 2:
                            SbiObj.closeAccount();
                            break;

                        case 3:
                            SbiObj.diposite();
                            break;
                        case 4:
                            SbiObj.withdraw();
                            break;
                        case 5:
                            SbiObj.display();
                            break;

                        default:
                            break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(" Exception " + e);
                }
                finally {
                    Console.WriteLine("Please select a Right option , the program is in the Do while and for loop");
                    Console.WriteLine("If you want to continue : (yes/no)");
                    response = Console.ReadLine();
                    Console.ReadKey();
                    Console.WriteLine("\n\n\n\n");

                }

            }
            while (response != "no");

            Console.WriteLine("End of the program");
            Console.ReadKey();

        }
    }
}
