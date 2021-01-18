using System;

namespace Factory_Method
{
    class Program
    {
        public int amountOfPeople;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type of troop: ");
            string forcekind = Console.ReadLine();
            TroopFactory tf = sendForcesToWarzone(forcekind);
            Console.WriteLine("Enter amount of troop: ");
            int amountOfPeople = Int32.Parse(Console.ReadLine());
            Troop troop = tf.createTroop(amountOfPeople);
            troop.Attack();
        }

        static TroopFactory sendForcesToWarzone(String forceKind) {
            if (forceKind.Equals("Air"))
            {
                return new AirTroopFactory();
            }
            else
            if (forceKind.Equals("Ground"))
            {
                return new GroundTroopFactory();
            }
            else
            if (forceKind.Equals("Sea"))
            {
                return new SeaTroopFactory();
            }
            else {
                throw new Exception("Trere is no such kind of troop");
            }

        }
    }
}
