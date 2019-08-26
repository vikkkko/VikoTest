using System;
using System.Threading.Tasks;

namespace VikoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(async ()=> {
                await Task.Delay(10000);
                throw new Exception("搞我呢");
            });
            t.Start();
            Console.ReadLine();
        }
    }
}
