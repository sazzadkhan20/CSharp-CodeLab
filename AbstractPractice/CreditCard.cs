using System;

namespace AbstractPractice
{
    class CreditCard : PaymentMethod
    {
        public override void payment()
        {
            Console.WriteLine("Credit Card Payment\n");
        }
    }
}
