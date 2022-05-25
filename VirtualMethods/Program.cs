using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            NPC[] npcs = new NPC[] { new NPC(), new Farmer(), new Warrior(), new Child() };
            foreach (var npc in npcs)
            {
                npc.ShowInfo();
                Console.WriteLine("-------------------");
            }

            Console.ReadKey();
        }
    }

    class NPC
    {
        public virtual void ShowInfo()
        {
            Console.WriteLine("Я НПС, просто хожу.");
        }
    }

    class Farmer : NPC
    {
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Я фермер. Працюю.");
        }
    }

    class Warrior : NPC
    {
        public override void ShowInfo()
        {
            
            Console.WriteLine("Я воїн! Іду в бій!");
        }
    }

    class Child : NPC
    {

    }
}
