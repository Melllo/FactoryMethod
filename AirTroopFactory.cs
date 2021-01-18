using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class AirTroopFactory : TroopFactory
    {

        public Troop createTroop(int people)
        {
            return new AirTroop(people);
        }
    }
}
