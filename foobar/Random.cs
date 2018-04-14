using System;

namespace foobar
{


    class Random
    {

        public int option;


        public Random(int userOption) => option = userOption;

        public int User
        {
            get => option;
            set => option = value;
        }


        public void Message() {

            if (option == 1) {

                Console.WriteLine("This is a random message.");

            }
            else {

                Console.WriteLine("Hail Zorp!!!!");

            }
            
            

        }










    }















}