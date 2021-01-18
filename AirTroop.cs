using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class AirTroop : Troop
    {
        int people;
        public AirTroop() { }
        public AirTroop(int people)
        {
            this.people = people;
        }
            public void Attack()
        {
            Console.WriteLine("Attack from Airfrom " + people + " people! Bdummmm!!! ");
        }
    }
}
