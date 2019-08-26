using System;
using System.Threading.Tasks;

namespace VikoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = args[0];
            Task t = new Task(async ()=> {
                await Task.Delay(10000);

                Console.WriteLine(c+"       "+System.DateTime.Now);
                throw new Exception("error");
            });
            t.Start();
            Console.ReadLine();
        }
    }
}
