using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) {
                Console.WriteLine("Customer Successfull Added" + "\n"
                + "Customer Name: " + customer.FirstName+" "+customer.LastName+"\n"+"Customer Country: "+customer.Country+"\n"
                +"Customer Identity Number: " + customer.IdentityNumber+"\n"+ "Customer ID: " + customer.Id+"\n");
           



        }
        public void Update(Customer customer,Customer updatedCustomer) {

            Console.WriteLine("******************************************************************************");
            
            Console.WriteLine("Customer Updated !!!" + "\n"+ "Customer Name: " + 
                updatedCustomer.FirstName + " " + 
                updatedCustomer.LastName + "\n" + "IdentityNumber : " + updatedCustomer.IdentityNumber +"\n" + "Country : " + updatedCustomer.Country+"\n"+ "Customer ID : "
                + updatedCustomer.Id+"\n");
            customer.FirstName = updatedCustomer.FirstName;
            customer.LastName = updatedCustomer.LastName;
            customer.IdentityNumber = updatedCustomer.IdentityNumber;
            customer.Country = updatedCustomer.Country;
            customer.Id = updatedCustomer.Id;
            Console.WriteLine("******************************************************************************");
            


        }
        public void Delete(Customer customer) {
            Console.WriteLine("Customer Successfully Deleted, Deleting Customer Information is"+ "\n" + "Deleted Customer First Name : " + "" + 
                customer.FirstName +" " +customer.LastName + "\n"+ "Deleted Customer Country : " + ""+customer.Country+"\n"+
                "Deleted Customer Identity Number : " + ""+customer.IdentityNumber+"\n"+"Deleted Customer ID : "+customer.Id);        
        }
        public int topla(int sayı1, int sayı2)
        {
            return sayı1 + sayı2;
        }

    }
}
