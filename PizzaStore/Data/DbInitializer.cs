using PizzaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PizzaContext context)
        {
            

            if (context.Employees.Any())
            {
                return;
            }

            Employee[] employees = new Employee[]
            {
                new Employee{FirstName = "Donell", LastName = "Banks", PhoneNumber = "205-555-5557", Role = Roles.Manager, Salary = 97000m},
                new Employee{FirstName = "Jax", LastName = "Cassidy", PhoneNumber = "124-555-7849", Role = Roles.AssistantManager, Salary = 60000m},
                new Employee{FirstName = "Dilara", LastName = "Gardiner", PhoneNumber = "896-555-9565", Role = Roles.Driver, Salary = 30000m},
                new Employee{FirstName = "Hammad", LastName = "Goff", PhoneNumber = "322-555-5463", Role = Roles.Insider, Salary = 26000m},
                new Employee{FirstName = "Ayah", LastName = "Hodges", PhoneNumber = "895-555-7894", Role = Roles.Cashier, Salary = 24000m}
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
    }
}
