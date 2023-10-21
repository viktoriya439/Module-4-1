namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            /*int A;
            int B;
            double X;
            double Y;
            bool C = (A < B) | (X > Y);
            
            Console.WriteLine(C); 
            Console.ReadKey();*/

            /* var a = 5 + 6;
             var b = 7 + 8;

             var c = (b != a) & (b > a + 1);
             var d = (b != a) && (b > a + 1);

             Console.WriteLine(c);
             Console.WriteLine(d);
             Console.ReadKey();*/

            /*var a = 6;
            var b = 7;

            var c = (a < b) ^ (a != b);

            Console.WriteLine(c);
            Console.ReadKey(); */



            /*
             var inv = true; 
             var result = !inv;
            Console.WriteLine(result);*/

            /*
            var a = 6;
            var b = 7;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            } 
            */

            /*
            var a = 6;
            var b = 7;

            if (a == b && b > 1)
            {
                Console.WriteLine("Условие истинно");
            }

            else if (b > 10 || b == 7)
            {
                Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0}", b);
            }


            var a = 6;
            var b = 7;

            var c = a != b ? a + b : b;

            Console.WriteLine(c);
            */
            #endregion

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }

            #region
            /*int A;
            int B;
            double X;
            double Y;
            bool C = (A < B) | (X > Y);
            
            Console.WriteLine(C); 
            Console.ReadKey();*/

            /* var a = 5 + 6;
             var b = 7 + 8;

             var c = (b != a) & (b > a + 1);
             var d = (b != a) && (b > a + 1);

             Console.WriteLine(c);
             Console.WriteLine(d);
             Console.ReadKey();*/

            /*var a = 6;
            var b = 7;

            var c = (a < b) ^ (a != b);

            Console.WriteLine(c);
            Console.ReadKey(); */



            /*
             var inv = true; 
             var result = !inv;
            Console.WriteLine(result);*/

            /*
            var a = 6;
            var b = 7;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            } 
            */

            /*
            var a = 6;
            var b = 7;

            if (a == b && b > 1)
            {
                Console.WriteLine("Условие истинно");
            }

            else if (b > 10 || b == 7)
            {
                Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0}", b);
            }


            var a = 6;
            var b = 7;

            var c = a != b ? a + b : b;

            Console.WriteLine(c);
            */
            #endregion
        }
    }
}