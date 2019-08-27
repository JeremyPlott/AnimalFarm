using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesIntroduction {

    class Student {

        //creating properties of the class

        public string Firstname { get; set; }   //get - allowed to read data. set - allowed to set data
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; } //type 'prop' and hit tab twice. Tab between the two fields, hit enter at end. 
        public int FinalGrade { get; set; }

        //adding a method

        public string GetFullname() {
            return $"{Firstname} {Lastname}"; //cleaned this line up from the extended concat line.
        }

        public void SetFinalGrade(int finalGrade) { //void set for return type because it won't be returning anything
            if(finalGrade < 0) {
                Console.WriteLine("ERROR - grade must be greater than zero");
                return;  //return statement can be used, but a value can't be assigned to it. Ends method there.
            } else {
                FinalGrade = finalGrade;                
            }

        }

    }
}
