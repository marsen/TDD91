using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD91
{
    public class ShoppingCart
    {
        public decimal CheckOut(ShoppingCartContext context)
        {
            if (context.type == "TotalPrice")
            {
                if (context.totalPrice >= 500)
                {
                    context.totalPrice = context.totalPrice - 200;
                }
            }
            else
            {
                if (context.count >= 3)
                {
                    context.totalPrice = context.totalPrice * 0.8m;
                }

            }

            return context.totalPrice;
        }
    }
}
