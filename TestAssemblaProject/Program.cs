using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace TestAssemblaProject
{
    /// <summary>
    /// Main program class
    /// </summary>
    class Program
    {
        readonly CancellationTokenSource _cts = 
            new CancellationTokenSource();

        static void Main(int[] args)
        {
            /* Create a new instance of the program class*/
            var p = new Program();
            var r = new OtherClass();
            r.ShowSum();
            p.SayHello();            
        }

        private void SayHello()
        {
            var token =
                _cts.Token;
            
            var task =
                new Task(()=>OutputHello(token), token);

            task.ContinueWith(t => SayGoodBye());

            task.Start();

            Console.ReadLine();
            _cts.Cancel();

            Console.ReadLine();
        }

        private void SayGoodBye()
        {
            Console.WriteLine("Good bye...");
        }

        private void OutputHello(CancellationToken token)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Hello, Assembla! Press Enter to cancel...");
                    token.ThrowIfCancellationRequested();
                    Thread.Sleep(100);
                }
            }
            catch (OperationCanceledException)
            {
                
                Console.WriteLine("Canceled....");
                
            }
            
        }
    }
} //testing automerge
