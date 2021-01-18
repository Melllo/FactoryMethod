using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class SeaTroopFactory : TroopFactory
    {
        public Troop createTroop(int people)
        {
            return new SeaTroop(people);
        }
        
    }
}
