using System.Diagnostics;


namespace HomeWork7_OTUS
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Вычисление через рекурсию");
            Stopwatch st1 = new Stopwatch();

            st1.Start();
            FiboRecursion(5);
            st1.Stop();
            Console.WriteLine($"Время поиска 5 члена составило: {st1.Elapsed} \n");

            st1.Restart();
            FiboRecursion(10);
            st1.Stop();
            Console.WriteLine($"Время поиска 10 члена составило: {st1.Elapsed} \n");

            st1.Restart();
            FiboRecursion(20);
            st1.Stop();
            Console.WriteLine($"Время поиска 20 члена составило: {st1.Elapsed} \n");

            //-------------------------------------------------------------------

            Console.WriteLine("Вычисление через цикл");
            Stopwatch st2 = new Stopwatch();

            st2.Start();
            FiboCycle(5);
            st2.Stop();
            Console.WriteLine($"Время поиска 5 члена составило: {st2.Elapsed} \n");

            st2.Restart();
            FiboCycle(10);
            st2.Stop();
            Console.WriteLine($"Время поиска 10 члена составило: {st2.Elapsed} \n");

            st2.Restart();
            FiboCycle(20);
            st2.Stop();
            Console.WriteLine($"Время поиска 20 члена составило: {st2.Elapsed} \n");
        }

        public static void FiboRecursion(int n, int Fn_1 = 1, int Fn_2 = 0)
        {
            if (n == 0 || n == 1) 
            {
                Console.WriteLine($"Значение равно {n}");
                return;
            }            
            else
            {
                int Fn = Fn_1 + Fn_2;
                Fn_2 = Fn_1;
                Fn_1 = Fn;
                n--;
                if (n-1 == 0)
                {
                    Console.WriteLine($"Значение равно {Fn}");
                    return;
                }
                FiboRecursion(n, Fn_1, Fn_2);
            }
        }

        public static void FiboCycle(int n)
        {
            int Fn_1 = 1;
            int Fn_2 = 0;
            int Fn = 0;

            if (n == 0 || n == 1)
            {
                Console.WriteLine($"Значение равно {n}");
                return;
            }
            else
            {                
                for (int i = 1; i <n; i++)
                {
                    Fn = Fn_1 + Fn_2;
                    Fn_2 = Fn_1;
                    Fn_1 = Fn;                    
                }                
            }
            Console.WriteLine($"Значение равно {Fn}");

        }
    }
}