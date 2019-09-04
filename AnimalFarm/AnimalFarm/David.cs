using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm {

    class David : ISpeak {
        ISpeak speak;

        public void Speak() {
            speak.Speak();
        }

        public David(ISpeak speak) {
            this.speak = speak;
        }
    }
}
