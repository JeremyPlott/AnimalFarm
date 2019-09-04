using System;
using AnimalFarm.Sounds;
using System.Collections.Generic;

namespace AnimalFarm {

    class Program {

        static void Main(string[] args) {

            var cow = new Cow(new Moo()); //moo is in a different namespace, be sure to add it.
            cow.Speak();

            var cat = new Cat(new Meow());
            cat.Speak();

            var david = new David(new MeoOOO()); //is it a cow with cat legs?
            david.Speak();

            var animals = new List<ISpeak>();
            animals.Add(cat);
            animals.Add(cow);
            animals.Add(david);

            foreach(var animal in animals) {
                animal.Speak();
            }
        }
    }
}
