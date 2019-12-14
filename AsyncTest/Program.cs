using System;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DecompiledProgram.MainWork(args);      
            //(new Program()).WaitForMe();
        }

        public async void WaitForMe()
        {
            var result = await CallMe();
            var result2 = await CallMe();
            
            Console.WriteLine("Result1 : " + result +" Result2: "+ result2 + "Ende !");

        }

        public async Task<int> CallMe()
        {
            return 1;                                    
        }

    }
}
