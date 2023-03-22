using System;
using System.Threading;


namespace Smartwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Menu(){
            Console.WriteLine()
        }

        static void Start(int time){
            int currentTime = 0;
            while(currentTime != time)
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado!!");
        }
    }
}