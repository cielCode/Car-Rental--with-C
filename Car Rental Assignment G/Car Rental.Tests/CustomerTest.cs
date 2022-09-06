using Car_Rental.Common.Classes;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;
using Car_Rental.Data.Classes;
using System;
using System.Linq;
using Xunit;

namespace Car_Rental.Tests
    
{
    public class CustomerTest
    {        
        [Fact]
        public void CanCreateCustomer()
        {
            IPerson customer = new Customer(1, "1234", "John", "Doe");

            Assert.Equal("Doe John (1234)", customer.ToString());
        }

        [Fact]
        public void CanReadCustomers()
        {
            IData data = new CollectionData();

            Assert.True(data.GetPersons().Count() > 0);
        }

    }
}
