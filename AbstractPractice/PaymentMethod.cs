using System;

namespace AbstractPractice
{
    /*In Abstract Class there will  be general and abstract method both should be present
     * and In Abstract Class where only present abstract method that is called perfect Abstraction(Interface)
     * In Child classes abstract method must be inherited and abstract class have no object(Reference)
     */
    abstract class PaymentMethod
    {
        //Non Abstract Method
        public void showInfo()
        {
            Console.WriteLine("Show Information\n");
        }
        //Abstract Method(can not have body)
        public abstract void payment();
    }
}
