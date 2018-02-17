using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {

        Console.WriteLine("\nLaw of Cosines Calculator");

        Cosine Cosine1 = new Cosine();

        while (Cosine1.Initiate != "quit")
        {
            Console.WriteLine($"\nTo continue, press enter or type 'quit', then press enter to terminate program."); // Ask the user if they would like to continue running the program
            Cosine1.Initiate = Console.ReadLine();

            if (Cosine1.Initiate != "quit") // if user doesn't type "quit"
            {
                Console.WriteLine("\nPlease enter the first known side of the oblique triangle (decimal inches): "); // Ask the user for the first known side of the oblique triangle
                string knownSide1 = Console.ReadLine();
                try
                {
                    Cosine1.KnownSide1 = Convert.ToDouble(knownSide1);
                    Console.WriteLine($"\n The first known side is: {Cosine1.KnownSide1}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($" No valid entry was given. " + ex.Message);
                    return;
                }
                
                Console.WriteLine("\nPlease enter the second known side of the oblique triangle (decimal inches): "); // Ask the user for the second known side of the oblique triangle
                string knownSide2 = Console.ReadLine();
                try
                {
                    Cosine1.KnownSide2 = Convert.ToDouble(knownSide2);
                    Console.WriteLine($"\nThe second known side is: {Cosine1.KnownSide2}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($" No valid entry was given. " + ex.Message);
                    return;
                }


                Console.WriteLine($"\nPlease enter the angle (in degrees) opposite to the unknown side of the triangle \n(the side whose length you're trying to find): ");

                // Ask the user for the known angle in degrees
                // To use the law of Cosines to find the missing side, this will need to be the angle opposite to the unknown side 
                // (the side we are trying to find)
                string knownAngle = Console.ReadLine();

                try
                {
                    Cosine1.KnownAngle = Convert.ToDouble(knownAngle);
                    Console.WriteLine($"\nThe known angle (in degrees) is: {Cosine1.KnownAngle:F}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($" No valid entry was given. " + ex.Message);
                    return;
                }

                double knownAngleRadians = (Cosine1.KnownAngle * Math.PI) / 180; // Convert the known angle into radians
                Cosine1.KnownAngleRadians = knownAngleRadians;

                double knownAngleCos = Math.Cos(Cosine1.KnownAngleRadians); // Convert the known angle in radians into the cosine of the known angle
                Cosine1.KnownAngleCos = knownAngleCos;

                Console.WriteLine($"\nThe cosine of the known angle is: {Cosine1.KnownAngleCos:F}");

                // Calculate the missing side using the law of cosines
                // C = sqrt(a^2 + b^2 - 2ab cosy)

                double aPow2 = Math.Pow(Cosine1.KnownSide1, 2); // Take the first known side to the second power
                Cosine1.APow2 = aPow2;

                double bPow2 = Math.Pow(Cosine1.KnownSide2, 2); // Take the second known side to the second power
                Cosine1.BPow2 = bPow2;

                double missingSide = Math.Sqrt(Cosine1.APow2 + Cosine1.BPow2 - ((2) * (Cosine1.KnownSide1 * Cosine1.KnownSide2) * (Cosine1.KnownAngleCos))); // apply Law of Cosines
                Cosine1.MissingSide = missingSide;

                Console.WriteLine($"\nThe missing side of the triangle is: {Cosine1.MissingSide:F} inches"); // Give the user the missing side
            }

        }   
    }
    }

 