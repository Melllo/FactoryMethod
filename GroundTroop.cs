using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class GroundTroop : Troop
    {
        int people;

        public GroundTroop() { }
        public GroundTroop(int people)
        {
            this.people = people;
        }
            public void Attack()
        {
            Console.WriteLine("Attack on groundfrom " + people + " people! Bdummmm!!! ");
        }
    }
}
