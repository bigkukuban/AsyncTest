using System;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DecompiledProgramm.MainWork(args);      
        }

        public async void WaitForMe()
        {
            var resutl = await CallMe();            

            Console.WriteLine("Result1 : "+ resutl + "Ende !");
            
        }

        public async Task<int> CallMe()
        {
            return 1;                                    
        }

    }
}
