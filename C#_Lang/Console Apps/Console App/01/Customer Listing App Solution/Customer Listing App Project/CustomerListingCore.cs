using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Listing_App_Project
{
    /// <summary>
    /// This will generate Guid.
    /// </summary>
    /// <param name="Value"></param>
    readonly record struct CustomerId(Guid Value)
    {
        public static CustomerId Empty => new(Guid.Empty);
        public static CustomerId NewCustomerId() => new(Guid.NewGuid());
    }

    abstract record CustomerListingCore;

    sealed record RegularCustomer : CustomerListingCore
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Gender { get; set; } = string.Empty;
        public CustomerId Id { get; set; } = CustomerId.NewCustomerId();

        public RegularCustomer() { }
        public RegularCustomer(string firstName, string lastName, int age, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }
    }

}
