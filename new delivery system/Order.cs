using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace new_delivery_system
{
    class Order : DataCustomer
    {
        protected ArrayList order_data = new ArrayList();
        protected ArrayList staff_data = new ArrayList();
        Customer temp_data = new Customer();
        food foodDrink = new food();
        Staff temp_staff = new Staff();
        string selectedID;
        double total = 0;

        public string searchCustomer()  //method for search data customer using recursive
        {
            int custCount = customer_data.Count - 1;
            string status = "failed";

            Customer cust = new Customer();

            int n = 0;
            n = customer_data.Count - 1;

        reEnter:
            Console.WriteLine();
            Console.Write("Please Insert Identification Number: ".PadLeft(77));
            selectedID = Console.ReadLine();
            foodDrink.custID = Convert.ToInt32(selectedID);
            custCount = search(customer_data, selectedID, custCount);

            if (custCount < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Data is not exist".PadLeft(70));
                Console.WriteLine();
                Console.Write("Do you want to enter another ID? (Y/N): ".PadLeft(77));
                string reanswer= Console.ReadLine();

                if (reanswer.ToUpper() == "Y")
                {
                    goto reEnter;
                }
                else 
                {
                    return status;
                }
            }
            else
            {
                Console.Clear();
                menuOrder();
                status = "success";
            }
            return status;
        }
        public int search(ArrayList customer_data, string selectedID, int n)
        {
            Customer cust = new Customer();

            if (n >= 0)
            {
                cust = (Customer)customer_data[n];

                if (selectedID == Convert.ToString(cust.custID))
                    return n;
                else
                {
                    n = search(customer_data, selectedID, n - 1); //
                    return n;
                }
            }
            else
                return -1;
        }

        public void menuOrder()
        {
            food myfood = new food();
            myfood.totalall = 0;
            DateTime date = DateTime.Now;
            string food;

            reOrder:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("******* MENU FOR ORDERING *******".PadLeft(75));
                Console.WriteLine();
                Console.WriteLine("1.".PadLeft(50) + "Special".PadLeft(4));
                Console.WriteLine("2.".PadLeft(50) + "Ala Carte".PadLeft(4));
                Console.WriteLine("3.".PadLeft(50) + "Dessert".PadLeft(4));
                Console.WriteLine("4.".PadLeft(50) + "Beverage".PadLeft(3));
                Console.WriteLine("5.".PadLeft(50) + "Back to MAIN MENU".PadLeft(4));
                Console.WriteLine("6.".PadLeft(50) + "Exit".PadLeft(4));
                Console.WriteLine();
                Console.WriteLine("*********************************".PadLeft(75));
                Console.WriteLine();
                Console.Write("\n\t\t\t\t\tPlease make your choice between 1 - 6: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("******************** SPECIAL MENU ********************".PadLeft(80));
                        Console.WriteLine();
                        Console.WriteLine("1.".PadLeft(30) + "Chicken Bundle A - Regular (4-5 Pax) RM 39.90");
                        Console.WriteLine("2.".PadLeft(30) + "Chicken Bundle B - Regular (2-3 Pax) RM 22.00");
                        Console.WriteLine("3.".PadLeft(30) + "Beef Bundle A - Regular (4-5 Pax) RM 39.90");
                        Console.WriteLine("4.".PadLeft(30) + "Beef Bundle B - Regular (2-3 Pax) RM 22.00");
                        Console.WriteLine("5.".PadLeft(30) + "Back to MAIN MENU");
                        Console.WriteLine();
                        Console.WriteLine("******************************************************".PadLeft(80));
                        Console.WriteLine();
                    reCodeA:
                        Console.Write("\t\t\t\tPlease Enter Your Choice from 1 - 5: ");
                        food = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Date and Time Order: ".PadLeft(54));
                        Console.WriteLine(date.ToString("g"));
                        Console.WriteLine();
                        Console.Write("Quantity            : ".PadLeft(55));
                        myfood.quantity = int.Parse(Console.ReadLine());

                        if (food == "1")
                        {
                            myfood.package = "Chicken Bundle A - Regular (4-5 Pax)";
                            myfood.price = 39.90;
                            total = total + 39.90;
                            total = total * myfood.quantity;

                        }
                        else if (food == "2")
                        {
                            myfood.package = "Chicken Bundle B - Regular (2-3 Pax)";
                            myfood.price = 22.00;
                            total = total + 22.00;
                            total = total * myfood.quantity;
                        }
                        else if (food == "3")
                        {
                            myfood.package = "Beef Bundle A - Regular (4-5 Pax)";
                            myfood.price = 39.90;
                            total = total + 39.90;
                            total = total * myfood.quantity;
                        }
                        else if (food == "4")
                        {
                            myfood.package = "Beef Bundle B - Regular (2-3 Pax)";
                            myfood.price = 22.20;
                            total = total + 22.00;
                            total = total * myfood.quantity;
                        }
                        else if (food == "5")
                        {
                            Console.Clear();
                            goto reOrder;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\tWrong code!!! Please re-enter the correct code");
                            goto reCodeA;
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("******************** ALA CARTE MENU ********************".PadLeft(80));
                        Console.WriteLine();
                        Console.WriteLine("1.".PadLeft(30) + "Ayam Goreng McD - Regular (2 Pcs) RM 10.90");
                        Console.WriteLine("2.".PadLeft(30) + "Mc Chicken RM 7.50");
                        Console.WriteLine("3.".PadLeft(30) + "Spicy Chicken McDeluxe RM 10.50");
                        Console.WriteLine("4.".PadLeft(30) + "Cheese Burger RM 5.50");
                        Console.WriteLine("5.".PadLeft(30) + "GCB RM 11.50");
                        Console.WriteLine("6.".PadLeft(30) + "French Fries RM 5.00");
                        Console.WriteLine("7.".PadLeft(30) + "Bubur Ayam Mcd RM 8.50");
                        Console.WriteLine("8.".PadLeft(30) + "Back to MAIN MENU");
                        Console.WriteLine();
                        Console.WriteLine("******************************************************".PadLeft(80));
                        Console.WriteLine();
                    reCodeB:
                        Console.Write("\t\t\t\tPlease Enter Your Choice from 1 - 8: ");
                        food = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Date and Time Order: ".PadLeft(54));
                        Console.WriteLine(date.ToString("g"));
                            Console.WriteLine();
                            Console.Write("Quantity            : ".PadLeft(55));
                            myfood.quantity = int.Parse(Console.ReadLine());

                        if (food == "1")
                        {
                            myfood.package = "Ayam Goreng McD - Regular (2 Pcs)";
                            myfood.price = 10.90;
                            total = total + 10.90;
                            total = total * myfood.quantity;
                        }
                        else if (food == "2")
                        {
                            myfood.package = "Mc Chicken";
                            myfood.price = 7.50;
                            total = total + 7.50;
                            total = total * myfood.quantity;
                        }
                        else if (food == "3")
                        {
                            myfood.package = "Spicy Chicken McDeluxe";
                            myfood.price = 10.50;
                            total = total + 10.50;
                            total = total * myfood.quantity;
                        }
                        else if (food == "4")
                        {
                            myfood.package = "Cheese Burger";
                            myfood.price = 5.50;
                            total = total + 5.50;
                            total = total * myfood.quantity;
                        }
                        else if (food == "5")
                        {
                            myfood.package = "GCB";
                            myfood.price = 11.50;
                            total = total + 11.50;
                            total = total * myfood.quantity;
                        }
                        else if (food == "6")
                        {
                            myfood.package = "French Fries";
                            myfood.price = 5.00;
                            total = total + 5.00;
                            total = total * myfood.quantity;
                        }
                        else if (food == "7")
                        {
                            myfood.package = "Bubur Ayam Mcd";
                            myfood.price = 8.50;
                            total = total + 8.50;
                            total = total * myfood.quantity;
                        }
                        else if (food == "8")
                        {
                            Console.Clear();
                            goto reOrder;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\tWrong code!!! Please re-enter the correct code");
                            goto reCodeB;
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("******************** DESSERT MENU ********************".PadLeft(80));
                        Console.WriteLine();
                        Console.WriteLine("1.".PadLeft(30) + "Apple Pie RM 3.10");
                        Console.WriteLine("2.".PadLeft(30) + "Chocolate Sundae RM 3.70");
                        Console.WriteLine("3.".PadLeft(30) + "Strawberry Sundae RM 3.70");
                        Console.WriteLine("4.".PadLeft(30) + "Oreo McFlurry RM 4.80");
                        Console.WriteLine("5.".PadLeft(30) + "Back to MAIN MENU");
                        Console.WriteLine();
                        Console.WriteLine("******************************************************".PadLeft(80));
                        Console.WriteLine();
                    reCodeC:
                        Console.Write("\t\t\t\tPlease Enter Your Choice from 1 - 5: ");
                        food = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Date and Time Order: ".PadLeft(54));
                        Console.WriteLine(date.ToString("g"));
                            Console.WriteLine();
                            Console.Write("Quantity            : ".PadLeft(55));
                            myfood.quantity = int.Parse(Console.ReadLine());

                        if (food == "1")
                        {
                            myfood.package = "Apple Pie";
                            myfood.price = 3.10;
                            total = total + 3.10;
                            total = total * myfood.quantity;
                        }
                        else if (food == "2")
                        {
                            myfood.package = "Chocolate Sundae";
                            myfood.price = 3.70;
                            total = total + 3.70;
                            total = total * myfood.quantity;
                        }
                        else if (food == "3")
                        {
                            myfood.package = "Strawberry Sundae";
                            myfood.price = 3.70;
                            total = total + 3.70;
                            total = total * myfood.quantity;
                        }
                        else if (food == "4")
                        {
                            myfood.package = "Oreo McFlurry";
                            myfood.price = 4.80;
                            total = total + 4.80;
                            total = total * myfood.quantity;
                        }
                        else if (food == "5")
                        {
                            Console.Clear();
                            goto reOrder;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\tWrong code!!! Please re-enter the correct code");
                            goto reCodeC;
                        }
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("******************** BEVERAGE MENU ********************".PadLeft(80));
                        Console.WriteLine();
                        Console.WriteLine("1.".PadLeft(30) + "Coca Cola RM 3.50");
                        Console.WriteLine("2.".PadLeft(30) + "Sprite RM 3.50");
                        Console.WriteLine("3.".PadLeft(30) + "Ice Lemon Tea RM 4.20");
                        Console.WriteLine("4.".PadLeft(30) + "Milo RM 5.20");
                        Console.WriteLine("5.".PadLeft(30) + "Back to MAIN MENU");
                        Console.WriteLine();
                        Console.WriteLine("******************************************************".PadLeft(80));
                        Console.WriteLine();
                    reCodeD:
                        Console.Write("\t\t\t\tPlease Enter Your Choice from 1 - 5: ");
                        food = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Date & Time purchase: ".PadLeft(54));
                        Console.WriteLine(date.ToString("g"));
                        Console.WriteLine();
                        Console.Write("Quantity            : ".PadLeft(55));
                        myfood.quantity = int.Parse(Console.ReadLine());

                        if (food == "1")
                        {
                            myfood.package = "Coca Cola";
                            myfood.price = 3.50;
                            total = total + 3.50;
                            total = total * myfood.quantity;

                        }
                        else if (food == "2")
                        {
                            myfood.package = "Sprite";
                            myfood.price = 3.50;
                            total = total + 3.50;
                            total = total * myfood.quantity;
                        }
                        else if (food == "3")
                        {
                            myfood.package = "Ice Lemon Tea";
                            myfood.price = 4.20;
                            total = total + 4.20;
                            total = total * myfood.quantity;
                        }
                        else if (food == "4")
                        {
                            myfood.package = "Milo";
                            myfood.price = 5.20;
                            total = total + 5.20;
                            total = total * myfood.quantity;
                        }
                        else if (food == "5")
                        {
                            Console.Clear();
                            goto reOrder;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\tWrong code!!! Please re-enter the correct code");
                            goto reCodeD;
                        }
                        break;
                    case "5":
                        return;
                        break;

                    case "6":
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
                            return;
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
                myfood.totalall = myfood.totalall + total;
                order_data.Add(myfood);  
                Console.WriteLine();
                Console.WriteLine("The Total Price For This Order is RM ".PadLeft(70) + myfood.totalall);     
        }
        public void viewOrder()
        {
            int count = order_data.Count;

            DateTime date = DateTime.Now;
            Console.WriteLine();
            retart:
            Console.Write("Do you want to proceed order? (Y/N): ".PadLeft(75));
            string proceed = Console.ReadLine().ToUpper();

            if (proceed == "Y")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Please Check First Before Proceed".PadLeft(75));
                Console.WriteLine();
                Console.Write("Date and Time Order: ".PadLeft(60));
                Console.WriteLine(date.ToString("g"));
                Console.WriteLine();
                Console.WriteLine("\tCustomer ID           : ".PadLeft(50) + foodDrink.custID);
                Console.WriteLine("*************************************************************".PadLeft(92));
                foreach (object data in order_data)
                {
                    foodDrink = (food)data;

                    Console.WriteLine("\tFood Name             : ".PadLeft(50) + foodDrink.package);
                    Console.WriteLine("\t\tPrice                 : RM ".PadLeft(50) + foodDrink.price.ToString("#.00"));
                    Console.WriteLine("\tQuantity purchase     : ".PadLeft(50) + foodDrink.quantity);
                    Console.WriteLine();
                }
                Console.WriteLine("*************************************************************".PadLeft(92));
                Console.WriteLine("\tYour Total Price = RM ".PadLeft(63) + foodDrink.totalall.ToString("#.00"));
                Console.WriteLine();
            }
            else if (proceed == "N")  //taknak baca
            {
                order_data.Remove(foodDrink);
                Console.WriteLine();
                Console.WriteLine("Your order have been cancel".PadLeft(75));
                Console.WriteLine("Thank you for using this system".PadLeft(75));
            repress:
                Console.WriteLine();
                Console.WriteLine("Please press Y to go Main Menu".PadLeft(75));
                string reY = Console.ReadLine().ToUpper();

                if (reY == "Y")
                {
                    return;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(82));
                    Console.WriteLine();
                    goto repress;
                }
            }
            else
            {
                Console.WriteLine();
                Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(82));
                Console.WriteLine();
                goto retart;
            }
            reenter:
                Console.Write("Are you sure want to proceed? (Y/N): ".PadLeft(80));
                string change = Console.ReadLine().ToUpper();
                if (change == "Y")
                {
                    displayOrder();
                    Console.ReadLine();
                }
                else if (change == "N")  //taknak baca
                {
                    order_data.Remove(foodDrink);
                    Console.WriteLine();
                    Console.WriteLine("Your order have been cancel".PadLeft(75));
                    Console.WriteLine("Thank you for using this system".PadLeft(75));

                repress:
                    Console.WriteLine();
                    Console.Write("Please press Y to go Main Menu : ".PadLeft(75));
                    string reY = Console.ReadLine().ToUpper();

                    if (reY == "Y")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(82));
                        Console.WriteLine();
                        goto repress;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Wrong code! Please re-enter the code either Y/N".PadLeft(82));
                    Console.WriteLine();
                    goto reenter;
                }
            }
        public void displayOrder()
        {
            DateTime otherDate = DateTime.Now;
            autoStaff();
            int index = 122;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("THANK YOU FOR ORDERING WITH US".PadLeft(75));
            Console.WriteLine();
            Console.WriteLine("\tDate and Time Delivery:".PadLeft(50) + otherDate.AddMinutes(10));
            Console.WriteLine();
            Console.WriteLine("\tCustomer ID           : ".PadLeft(50) + foodDrink.custID);
            Console.WriteLine("\tStaff ID              : ".PadLeft(50) + temp_staff.staffID);
            Console.WriteLine("\tStaff name            : ".PadLeft(50) + temp_staff.staffName);
            Console.WriteLine("\tStaff plate number    : ".PadLeft(50) + temp_staff.platenumber);
            Console.WriteLine("\tEstimate food arrived : ".PadLeft(50) + otherDate.AddMinutes(30));
            Console.WriteLine();
            Console.WriteLine("*************************************************************".PadLeft(92));
            foreach (object data in order_data)
            {
                foodDrink = (food)data;

                Console.WriteLine("\tFood Name             : ".PadLeft(50) + foodDrink.package);
                Console.WriteLine("\t\tPrice                 : RM ".PadLeft(50) + foodDrink.price.ToString("#.00"));
                Console.WriteLine("\tQuantity purchase     : ".PadLeft(50) + foodDrink.quantity);
                Console.WriteLine();
            }
            Console.WriteLine("*************************************************************".PadLeft(92));
            Console.WriteLine("\tYour Total Price = RM ".PadLeft(67) + foodDrink.totalall.ToString("#.00"));
            Console.WriteLine();
            Console.WriteLine("Thank You".PadLeft(67));
            Console.WriteLine("Have A Nice Day".PadLeft(69));
            Console.WriteLine();
            Console.WriteLine("Please press enter to go Main Menu page".PadLeft(82)); //keluar menu order

            foreach (object data in staff_data)
            {
                temp_staff = (Staff)data;
                if (temp_staff.staffID == index)
                {
                }
                index++;
            }
        }
        public void autoStaff()
        {
            temp_staff.staffName = "Salim";
            temp_staff.staffID = 124;
            temp_staff.platenumber = "EDH 6738";
            staff_data.Add(temp_staff);
            temp_staff.staffName = "Abu";
            temp_staff.staffID = 123;
            temp_staff.platenumber = "ZYH 2234";
            staff_data.Add(temp_staff);
            temp_staff.staffName = "Arif";
            temp_staff.staffID = 122;
            temp_staff.platenumber = "AFC 3321";
            staff_data.Add(temp_staff);
        }

    }
}
