using System;


namespace Lab_1
{
    class RoomDetail
    {
        static void Main(string[] args)
        {
            //Intro to the application

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");
            Console.WriteLine("\n");

            //defining variables
            double len, wid, hei;
            String x;
          
            do
            {
                Console.Write("Enter Length: ");
                while (!double.TryParse(Console.ReadLine(), out len))
                {
                    
                    Console.WriteLine("Not a valid number, Please try again.");
                    Console.WriteLine("\n");
                    Console.Write("Enter Length: ");
                }

                Console.Write("\n");

                Console.Write("Enter Width: ");
                while (!double.TryParse(Console.ReadLine(), out wid))
                {
                    Console.WriteLine("Not a valid number, Please try again.");
                    Console.WriteLine("\n");
                    Console.Write("Enter Width: ");
                }


                Console.Write("\n");

                Console.Write("Enter Height: ");
                while (!double.TryParse(Console.ReadLine(), out hei))
                {
                    Console.WriteLine("Not a valid number, Please try again.");

                    Console.Write("Enter Height: ");
                }

                Console.Write("\n");

                double area = (len * wid);

                double peri = 2 * (len + wid + hei);

                double vol = (len * wid * hei);

                Console.Write("Area: " + area);
                Console.Write("\n");

                Console.Write("Perimeter: " + peri);
                Console.Write("\n");

                Console.Write("Volume: " + vol);
                Console.Write("\n");

                Console.Write("\n");

                Console.WriteLine("Would you like to continue?");

                //This loop checks to see if the user entered y or n
                do
                {
                    Console.WriteLine("Please Enter (y/n): ");
                    x = Console.ReadLine();
                    var t = x.ToLower();
                    if ((t == "y") || (t == "n"))
                        break;
                } while (true);


                Console.Clear();

                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");
                Console.Write("\n");

            }

            while (x == "y");


        }
    }
}
