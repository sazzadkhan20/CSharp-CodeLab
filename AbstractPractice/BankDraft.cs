using System;

namespace AbstractPractice
{
    class BankDraft : PaymentMethod
    {
        public override void payment()
        {
            Console.WriteLine("BankDraft Payment\n");
        }
    }
}
