using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Programowanie_obiektowe28._01._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string p1 = null;
            string p2 = "kot";

            try
            {
                zadanie1(p1);
            }
            catch(Exception ex)
            {
                Exception newException = new Exception("error");

                Console.WriteLine($"nowy wyjątek: \n{newException}\n\n");
                Console.WriteLine($"przyczyna:\n{ex.StackTrace}\n\n");

                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine($"Stack trace:\n{ex.StackTrace}");

                throw;
            }

            static void zadanie1(string str)
            {
            if (str == null){throw new ArgumentNullException("Podany napis nie możeby być null'em.");}
            int len = str.Length;
            Console.WriteLine($"Długość napisu: {len}");
            }
            

            try
            {
                zadanie2();
            }
            catch(myEx1 e)
            {
                Console.WriteLine($"Złapano wyjątek {e.GetType().Name}");
            }
            catch (myEx2 e)
            {
                Console.WriteLine($"Złapano wyjątek {e.GetType().Name}");
            }
            catch (myEx3 e)
            {
                Console.WriteLine($"Złapano wyjątek {e.GetType().Name}");
            }

            static void zadanie2()
            {
                Random random = new Random();
                int randNumber = random.Next(1, 4);

                switch (randNumber)
                {
                    case 1:
                        throw new myEx1("Wyjątek nr.1");
                    case 2:
                        throw new myEx2("Wyjątek nr.2");
                    case 3:
                        throw new myEx3("Wyjątek nr.3");
                    default:
                        throw new InvalidOperationException("Nieprawidłowo wylosowana liczba.");
                }
            }
        }

            class myEx1 : Exception
            {
            public myEx1(string message) : base(message) { }
            }

            class myEx2 : Exception
            {
                public myEx2(string message) : base(message) { }
            }
            class myEx3 : Exception
            {
                public myEx3(string message) : base(message) { }
            }
        }
            */
            zadanie3();
            static void zadanie3()
            {
                SomeClass someClassObj = new SomeClass();
                try
                {
                    someClassObj.CanThrowException();
                    someClassObj.CanThrowException();
                    someClassObj.CanThrowException();
                    someClassObj.CanThrowException();
                    someClassObj.CanThrowException();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }

            }
        }
        public class SomeClass
        {
            public void CanThrowException()
            {
                if (new Random().Next(5) == 0)
                    throw new Exception();
            }
        }
    }
}