using System;

namespace AbstractPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //PaymentMethod p = new PaymentMethod(); //abstract class object not possible
            CreditCard cc = new CreditCard();
            cc.payment();
            BankDraft bd = new BankDraft();
            bd.payment();
            Console.ReadKey();
        }
    }
}
