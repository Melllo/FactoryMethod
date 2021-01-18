using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class SeaTroop : Troop
    {
        int people;
        public SeaTroop() { }
        public SeaTroop(int people) {
            this.people = people;
        }
        public void Attack()
        {
            Console.WriteLine("Attack from Sea from " + people+" people! Bdummmm!!! ");
        }
    }
}
