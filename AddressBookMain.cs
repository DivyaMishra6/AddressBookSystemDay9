﻿using AddressBookSystem;

namespace AddressBooksystem
{
    class AdressBookMainClass
    {
        List<AddPersonUC2> con = new List<AddPersonUC2>();
        AddPersonUC2 obj = new AddPersonUC2();
        public void AddDetails()
        {
            Console.WriteLine("Enter First Name: ");
            obj.firstname = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            obj.lastname = Console.ReadLine();

            Console.WriteLine("Enter Your MobileNumber: ");
            obj.mobilenumber = Console.ReadLine();

            Console.WriteLine("Enter Your Address: ");
            obj.address = Console.ReadLine();

            Console.WriteLine("Enter Your City: ");
            obj.city = Console.ReadLine();

            Console.WriteLine("Enter  Your State: ");
            obj.state = Console.ReadLine();

            Console.WriteLine("Enter Your Zip: ");
            obj.zip = Console.ReadLine();

            Console.WriteLine("Enter Your Email Id: ");
            obj.email = Console.ReadLine();

            con.Add(obj);
        }
        public void DisplayContact()
        {

            foreach (var change in con)
            {
                Console.WriteLine(change.ToString());
            }

        }
        public static void Main(string[] args)
        {

            Console.WriteLine("!!!!!!Welcome to Adress Book Program!!!!!!");
            Console.WriteLine(" ");
            AdressBookMainClass person = new AdressBookMainClass();
            Console.WriteLine("Do you want to add new contact YES(1) or NO(0)");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Please add new contact details: ");
                        person.AddDetails();
                        person.DisplayContact();
                        break;
                    }
                case 0:
                    {
                        Console.WriteLine("press any key for exit:");
                        break;
                    }

            }
        }


    }
}


       
        


        
        


        
    
    

