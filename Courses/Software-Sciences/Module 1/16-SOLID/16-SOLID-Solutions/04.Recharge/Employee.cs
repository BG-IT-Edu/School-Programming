namespace P04.Recharge
{
    using System;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base(id)
        {
        }
        public virtual string Sleep()
        {
            return "sleeping";
        }
        
    }
}
