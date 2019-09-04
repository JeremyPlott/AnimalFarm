using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Sounds {

    class Meow : ISpeak {

        public void Speak() {
            Console.WriteLine("Meow!");
        }
    }
}
