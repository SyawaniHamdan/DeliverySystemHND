using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace new_delivery_system
{
    class DataCustomer
    {
         protected ArrayList customer_data = new ArrayList(); //declare arraylist for data customer 
        Customer temp_data = new Customer(); //declare object for customer
        
        public void addData() //method for add customer
        {
            Customer custt = new Customer();  //declare new object for customer

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("*******************************".PadLeft(70));
            Console.WriteLine("REGISTRATION OF NEW CUSTOMER".PadLeft(68));
            Console.WriteLine("*******************************".PadLeft(70));
            Console.WriteLine();
            Console.WriteLine("Please Enter Fill In Your detail".PadLeft(70));
            Console.WriteLine();
            Console.Write("\t\t\t\t      Identification Number (eg:0): ");
            custt.custID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name                         : ".PadLeft(69));
            custt.custName = Console.ReadLine();
            Console.Write("Street Address               : ".PadLeft(69));
            custt.custAddress = Console.ReadLine();
            Console.Write("Postcode (eg:01234)          : ".PadLeft(69));
            custt.custPostcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("City                         : ".PadLeft(69));
            custt.custCity = Console.ReadLine();
            Console.Write("Phone Number (eg:0123456789) : ".PadLeft(69));
            custt.custPhoneNo = Convert.ToInt32(Console.ReadLine());

            customer_data.Add(custt); //store all records about  customer in arraylist

            Console.WriteLine("...................................".PadLeft(72));
            Console.WriteLine("Customer is Successful Register !!".PadLeft(72));
            Console.WriteLine("...................................".PadLeft(72));
        }
        public void deleteData()  // method for delete customer
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("**********************************".PadLeft(75));
            Console.WriteLine("DELETION OF CUSTOMER INFORMATION".PadLeft(74));
            Console.WriteLine("**********************************".PadLeft(75));
            Console.WriteLine();
            Console.Write("Please Insert Identification Number: ".PadLeft(77));
            int selectedCode = Convert.ToInt32(Console.ReadLine());

            foreach (object data in customer_data)
            {
                temp_data = (Customer)data;
                if (temp_data.custID == selectedCode)
                {
                    Console.WriteLine();
                    Console.WriteLine("Identification Number: {0}".PadLeft(70), temp_data.custID);
                    Console.WriteLine("Name                 : {0}".PadLeft(70), temp_data.custName);
                    Console.WriteLine("Street Address       : {0}".PadLeft(70), temp_data.custAddress);
                    Console.WriteLine("Postcode             : {0}".PadLeft(70), temp_data.custPostcode);
                    Console.WriteLine("City                 : {0}".PadLeft(70), temp_data.custCity);
                    Console.WriteLine("Phone Number         : {0}".PadLeft(70), temp_data.custPhoneNo);
                    Console.WriteLine();
                    Console.WriteLine("........................................................".PadLeft(87));
                    Console.WriteLine("Customer Information Detail {0} has successfully deleted".PadLeft(87), selectedCode);
                    Console.WriteLine("........................................................".PadLeft(87));
                }
                
            }
                    customer_data.Remove(temp_data);    //delete selected customer from arraylist

                    if (temp_data.custID != selectedCode)
                    {
                        Console.WriteLine("..........................".PadLeft(70));
                        Console.WriteLine("No record of this customer".PadLeft(70));
                        Console.WriteLine("..........................".PadLeft(70));
                    }
        }
        public void searchData()  //method for search data customer using recursive
        {
            int custCount = customer_data.Count - 1;
            string selectedID = " ";

            Customer cust = new Customer();

            int n = 0;
            n = customer_data.Count - 1;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("**********************************".PadLeft(75));
            Console.WriteLine("SEARCHING OF CUSTOMER INFORMATION".PadLeft(74));
            Console.WriteLine("**********************************".PadLeft(75));
            Console.WriteLine();
            reEnter:
            Console.Write("Please Insert Identification Number: ".PadLeft(77));
            selectedID = Console.ReadLine();
            custCount = searchCust(customer_data, selectedID, custCount); 

            if (custCount < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Data is not exist".PadLeft(70));
                Console.Write("Do you want to enter another ID? (Y/N): ".PadLeft(77));

                if (Console.ReadLine().ToUpper() == "Y")
                {
                    goto reEnter;
                }
                else
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("****************************".PadLeft(70));
                Console.WriteLine("Identification Number: {0}".PadLeft(70), temp_data.custID);
                Console.WriteLine("Name                 : {0}".PadLeft(70), temp_data.custName);
                Console.WriteLine("Street Address       : {0}".PadLeft(70), temp_data.custAddress);
                Console.WriteLine("Postcode             : {0}".PadLeft(70), temp_data.custPostcode);
                Console.WriteLine("City                 : {0}".PadLeft(70), temp_data.custCity);
                Console.WriteLine("Phone Number         : {0}".PadLeft(70), temp_data.custPhoneNo);
                Console.WriteLine("****************************".PadLeft(70));
                Console.WriteLine();
                Console.WriteLine("\t\tYou have successfully find the customer information".PadLeft(70));
                Console.WriteLine();
            }

        }
        public int searchCust(ArrayList customer_data, string selectedID, int n)
        {
            Customer cust = new Customer();

            if (n >= 0)
            {
                cust = (Customer)customer_data[n];

                if (selectedID == Convert.ToString(cust.custID))
                    return n;
                else
                {
                    n = searchCust(customer_data, selectedID, n - 1); //
                    return n;
                }
            }
            else
                return -1;
        }

        public void sortingData()
        { 
            foreach (Customer cust in customer_data)
            {
                int id = cust.custID;
                string name = cust.custName;

                Console.WriteLine("Customer Identification:" + "\t\tCustomer Name:");
                Console.WriteLine(" " + id + "\t\t\t\t\t" + name);
                Console.ReadLine();
            }
        }
        public void displayData()
        {
            int count = customer_data.Count;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("LIST OF ALL CUSTOMER INFORMATION".PadLeft(68));
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("NO".PadRight(5) + "Customer ID".PadLeft(10) + "Customer Name".PadLeft(18) + "Address".PadLeft(15) + "Postcode".PadLeft(25) + "City".PadLeft(10) + "Phone Number".PadLeft(25));

            int index = 1;
            foreach (object data in customer_data)
            {
                temp_data = (Customer)data; //read data from arraylist and store temporary in student
                Console.WriteLine("{0}".PadLeft(2) + "{1}".PadLeft(10) + "{2}".PadLeft(15) + "{3}".PadLeft(20) + "{4}".PadLeft(15) + "{5}".PadLeft(12) + "{6}".PadLeft(15) , index, temp_data.custID, temp_data.custName, temp_data.custAddress, temp_data.custPostcode, temp_data.custCity, temp_data.custPhoneNo); //display data in arraylist
                index++;
            }
            Console.ReadLine();
        }
    }
}

