using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_sounds
{
    class Animals
    {
        string animal_name;
        string animal_sound;
        public Animals(string name, string sound)
        {
            animal_name = name;
            animal_sound = sound;
        }
        static void Main(string[] args)
        {
            Animals animal_1 = new Animals("Puiul", "PIU");
            Animals animal_2 = new Animals("Vaca", "MUU");
            Animals animal_3 = new Animals("Oaia", "BEE");
            Animals animal_4 = new Animals("Porcul", "GUIT");

            Console.WriteLine(animal_1.animal_name + " scoate sunetul " + animal_1.animal_sound);
            Console.WriteLine(animal_2.animal_name + " scoate sunetul " + animal_2.animal_sound);
            Console.WriteLine(animal_3.animal_name + " scoate sunetul " + animal_3.animal_sound);
            Console.WriteLine(animal_4.animal_name + " scoate sunetul " + animal_4.animal_sound);

            Console.ReadKey();
        }
    }
}
