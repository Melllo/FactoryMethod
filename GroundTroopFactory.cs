using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class GroundTroopFactory : TroopFactory
    {
        public Troop createTroop(int people)
        {
            return new GroundTroop(people);
        }
    }
}
