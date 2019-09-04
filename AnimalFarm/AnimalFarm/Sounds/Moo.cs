using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Sounds {

    class Moo : ISpeak {

        public void Speak() {
            Console.WriteLine("Moo!");
        }
    }
}
