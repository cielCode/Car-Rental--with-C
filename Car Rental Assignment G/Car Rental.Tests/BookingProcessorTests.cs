using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using Car_Rental.Business.Classes;

namespace Car_Rental.Tests
{
    public class BookingProcessorTests
    {
        [Fact]
        public void CanReadCustomers() 
        {
            var bp = new BookingProcessor();
            Assert.True(bp.GetCustomers().Count() > 0);
        }

        [Fact]
        public void CanReadBookings()
        {
            var bp = new BookingProcessor();
            Assert.True(bp.GetBookings().Count() > 0);
        }

        [Fact]
        public void CanReadVehicles()
        {
            var bp = new BookingProcessor();
            Assert.True(bp.GetVehicles().Count() > 0);
        }
    }
}
