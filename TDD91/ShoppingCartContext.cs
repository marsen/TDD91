using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD91
{
    public class ShoppingCartContext
    {
        public decimal totalPrice { get; set; }

        public int count { get; set; }
      
        public string type { get; set; }
    }
}
