using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm {

    class Cow : ISpeak {

        ISpeak speak;

        public void Speak() {
            speak.Speak(); //anything that implements ISpeak has to have a Speak() method, so we can call it here.
        }

        public Cow(ISpeak speak) {
            this.speak = speak;
        }
    }
}
