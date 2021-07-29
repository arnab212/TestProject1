using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    public class Banking:Itest
    {
        int balance = 10000;
          public int deposit(int x)
        {
            balance = balance + x;
            return (balance);
        }
        public  int withdraw(int x)
        {
            if (x>balance)
            {
                throw new Exception ("Your balance is less, you are poor");
            }
            else
            {
                balance = balance - x;
                return (balance);
            }
            
        }

        public int demo(bool f)
        {
            if (f)
            {
                return 42;
            }
            else
            {
                throw new InvalidOperationException("Invalid");
            }
        }
    }
}
