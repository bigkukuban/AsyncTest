using System;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        static void Main(string[] args)
        {

       //     DecompiledProgramm.MainWork(args);



      //      Console.WriteLine("Hello World!");
            Program newPrg = new Program();
            newPrg.WaitForMe();
        }

        public async void WaitForMe()
        {
            var resutl = await CallMe();
            var resut2 = await CallMe();

            Console.WriteLine("Result1 : "+ resutl + " Result2 :" + resut2 + "Ende !");
            
        }

        public async Task<int> CallMe()
        {
            return 1;                                    
        }

    }
}
