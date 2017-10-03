using Xunit;
using TDD91;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD91.Tests
{
    public class ShoppingCartTests
    {
        [Fact()]
        public void Shopping_500_Checkout_300()
        {

            //// Arrange 
            var excepted = 300;
            var target = new ShoppingCart();
            var context = new ShoppingCartContext();
            context.totalPrice = 500;
            //// Act
            var actual = target.CheckOut(context);
            //// Assert
            Assert.Equal(excepted, actual);
        }
    }
}