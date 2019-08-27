using System;

namespace ClassesIntroduction {

    class Program {

        static void Main(string[] args) {       //Collapse + expand highlighted blocks of code with ctrl + m + h, ctrl + m + u
            var Lidya = new Student();
            Lidya.Firstname = "Lidya"; 
            Lidya.Lastname = "Tsegay";
            var fullname = Lidya.GetFullname();
            Console.WriteLine("Full name is " + fullname);
            Lidya.SetFinalGrade(99);

            var Justin = new Student();
            Justin.Firstname = "Justin";
            Justin.Lastname = "Dudley";
            fullname = Justin.GetFullname();
            Console.WriteLine($"Full name is {fullname}");    //cleaner way to deal with strings instead of concatenation
            Justin.SetFinalGrade(98);

            var Nick = new Student();
            Nick.Firstname = "Nick";
            Nick.Lastname = "Baker";
            fullname = Nick.GetFullname();
            Console.WriteLine($"Full name is {Nick.Firstname} {Nick.Lastname}");
            Nick.SetFinalGrade(-100);
            
        }
    }
}
