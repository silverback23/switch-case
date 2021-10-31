using System;

namespace kararYapıları_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch Case

                int DateTi= DateTime.Now.Month;
                switch(DateTi)
              {              
                case 1:
                    Console.WriteLine("Ocak ayındasınız ");
                    break;
                case 2:
                    Console.WriteLine("şubat ayındasınız ");
                    break;
                case 3:
                    Console.WriteLine("mart ayındasınız ");
                    break;
                default:
                    Console.WriteLine("Yanlış değer girdiniz ");
                    break;
                }
        }
    }
}
