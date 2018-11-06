using System.Threading.Tasks;

namespace ConsoleAsyncDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            Main().Wait();
        }

        static private async Task Main()
        {
            //do async stuff
        }
    }
}
