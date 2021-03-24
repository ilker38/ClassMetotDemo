using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer customer1 = new Customer();


            customer1.Id = 1;
            customer1.FirstName = "ilker";
            customer1.LastName = "Uras";
            customer1.IdentityNumber = "1234567890";
            customer1.Country = "Turkey";
            customerManager.Add(customer1);

            Customer customer2 = new Customer
            { Id = 2, FirstName = "Mustafa", LastName = "Uras", IdentityNumber = "0987654321", Country = "Turkey" };
            customerManager.Add(customer2);


            customerManager.Update(customer1, new Customer
            {
                Id = 1,
                IdentityNumber = "48596485156",
                FirstName = customer1.FirstName,
                LastName = customer1.LastName,
                Country = customer1.Country
            });



            customerManager.Update(customer2, new Customer
            {
                Id = 2,
                IdentityNumber = customer2.IdentityNumber,
                FirstName = "Fatih",
                LastName = customer2.LastName,
                Country = customer2.Country
        });


            customerManager.Delete(customer1);
            Console.WriteLine("---------------------------------");
            customerManager.Delete(customer2);

            int toplamasonucu = customerManager.topla(4, 6);
        Console.WriteLine(toplamasonucu* 10);
        }

}
}
