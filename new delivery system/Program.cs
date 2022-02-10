using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace new_delivery_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order();
            Customer temp_data = new Customer();
            string mystatus;
            string userChoice;
            char ans, ans2;

            while (true)
            {
            MainMenu:
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please make sure customer had been registered before make the order session".PadLeft(95));
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("WELCOME TO MC DONALD'S DELIVERY SYSTEM".PadLeft(75));
                Console.WriteLine();
                Console.WriteLine("********* MAIN MENU *********".PadLeft(70));
                Console.WriteLine();
                Console.WriteLine("1.".PadLeft(50) + "Customer Information".PadLeft(15));
                Console.WriteLine("2.".PadLeft(50) + "Order".PadLeft(4));
                Console.WriteLine("3.".PadLeft(50) + "Exit".PadLeft(3));
                Console.WriteLine();
                Console.WriteLine("*****************************".PadLeft(70));

                Console.Write("\n\t\t\t\t\tPlease Enter Your Choice from 1 - 3: ");
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                beginMenu:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("******* MENU FOR CUSTOMER *******".PadLeft(75));
                    Console.WriteLine();
                    Console.WriteLine("1.".PadLeft(50) + "Register customer".PadLeft(4));
                    Console.WriteLine("2.".PadLeft(50) + "Delete customer".PadLeft(4));
                    Console.WriteLine("3.".PadLeft(50) + "Search customer".PadLeft(4));
                    Console.WriteLine("4.".PadLeft(50) + "Sorting customer".PadLeft(4));
                    Console.WriteLine("5.".PadLeft(50) + "Display customer".PadLeft(4));
                    Console.WriteLine("6.".PadLeft(50) + "Back to MAIN MENU".PadLeft(4));
                    Console.WriteLine("7.".PadLeft(50) + "Exit".PadLeft(4));
                    Console.WriteLine();
                    Console.WriteLine("*********************************".PadLeft(75));

                    Console.Write("\n\t\t\t\t\tPlease Enter Your Choice from 1 - 6: ");
                    userChoice = Console.ReadLine();
                    switch (userChoice)
                    {
                        case "1":
                        register:
                            Console.Clear();
                            myOrder.addData();
                        reEnter:
                            Console.Write("Do you want to add another customer? (Y/N): ".PadLeft(77));
                            ans = Convert.ToChar(Console.ReadLine().ToUpper());
                            if (ans == 'Y')
                            {
                                goto register;
                            }
                            else if (ans == 'N')
                            {
                                goto beginMenu;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(77));
                                Console.WriteLine();
                                goto reEnter;
                            }
                            break;

                        case "2":
                        delete:
                            myOrder.deleteData();
                        recode:
                            Console.Write("Do you want to delete other data? (Y/N): ".PadLeft(75));
                            ans = Convert.ToChar(Console.ReadLine().ToUpper());
                            if (ans == 'Y')
                            {
                                goto delete;
                            }
                            else if (ans == 'N')
                            {
                                goto beginMenu;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(75));
                                Console.WriteLine();
                                goto recode;
                            }
                            break;
                        case "3":
                            Console.Clear();
                        search:
                            myOrder.searchData();
                        rechoice:
                            Console.Write("Do you want to search other data? (Y/N): ".PadLeft(75));
                            ans = Convert.ToChar(Console.ReadLine().ToUpper());
                            if (ans == 'Y')
                            {
                                goto search;
                            }
                            else if (ans == 'N')
                            {
                                goto beginMenu;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(75));
                                Console.WriteLine();
                                goto rechoice;
                            }
                            break;

                        case "4":
                            Console.Clear();
                            myOrder.sortingData();
                            break;

                        case "5":
                            Console.Clear();
                            myOrder.displayData();
                        redisplay:
                            Console.Write("Press Y to go back previous page? (Y): ".PadLeft(75));
                            ans = Convert.ToChar(Console.ReadLine().ToUpper());
                            if (ans == 'Y')
                            {
                                goto beginMenu;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.Write("Wrong code! Please re-enter the code".PadLeft(75));
                                Console.WriteLine();
                                goto redisplay;
                            }
                            break;
                        case "6":
                            Console.Clear();
                            goto MainMenu;
                            break;
                        case "7":
                        reenter:
                            Console.WriteLine();
                            Console.Write("Do you sure want to exit? (Y/N): ".PadLeft(75));
                            char sure = Convert.ToChar(Console.ReadLine().ToUpper());
                            if (sure == 'Y')
                            {
                                Environment.Exit(1);
                            }
                            else if (sure == 'N')
                            {
                                goto MainMenu;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(82));
                                Console.WriteLine();
                                goto reenter;
                            }
                            break;

                    }
                }
                else if (userChoice == "2")
                {
                    mystatus = myOrder.searchCustomer();
                redo:
                    if (mystatus == "failed")
                    {
                        Console.WriteLine();
                        Console.Write("Do you want re-enter choice? (Y): ".PadLeft(75));
                        ans = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (ans == 'Y')
                        {
                            goto MainMenu;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("Wrong code! Please re-enter the code Y only".PadLeft(75));
                            Console.WriteLine();
                            goto redo;
                        }
                    }
                    else
                    {
                    reChoice1:
                        Console.WriteLine();
                        Console.Write("Do you want to make another order? (Y/N): ".PadLeft(75));
                        ans2 = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (ans2 == 'Y')
                        {
                        }
                        else if (ans2 == 'N')
                        {
                            myOrder.viewOrder();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(82));
                            Console.WriteLine();
                            goto reChoice1;
                        }
                    }
                begin22:
                    myOrder.menuOrder();
            reChoice2:
                Console.WriteLine();
                    Console.Write("Do you want to make another order? (Y/N): ".PadLeft(75));
                    ans2 = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (ans2 == 'Y')
                    {
                        goto begin22;
                    }
                    else if (ans2 == 'N')
                    {
                        myOrder.viewOrder();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(82));
                        Console.WriteLine();
                        goto reChoice2;
                    }
                }

                else if (userChoice == "3")
                {
                reEnter:
                    Console.WriteLine();
                    Console.Write("Do you sure want to exit? (Y/N): ".PadLeft(75));
                    char sure = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (sure == 'Y')
                    {
                        Environment.Exit(1);
                    }
                    else if (sure == 'N')
                    {
                        goto MainMenu;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(82));
                        Console.WriteLine();
                        goto reEnter;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong Code! Please re-enter the correct code either 1 to 3".PadLeft(88));
                    Console.WriteLine("Please press enter to re-enter the code".PadLeft(78));
                    Console.ReadLine();
                }
            }
        }
    }
}
