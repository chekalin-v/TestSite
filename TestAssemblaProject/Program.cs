using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAssemblaProject
{
    class Program
    {
        CancellationTokenSource _cts = 
            new CancellationTokenSource();

        static void Main(string[] args)
        {
            Program p = new Program();
            var r = new OtherClass();
            r.ShowSum();
            p.SayHello();
            

            //Console.WriteLine();
                        
        }

        private void SayHello()
        {
            var token =
                _cts.Token;
            
            var task =
                new Task(()=>OutputHello(token), token);            

            task.Start();

            Console.ReadLine();
            
            _cts.Cancel();


        }

        private void OutputHello(CancellationToken token)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Hello, Assembla! Press any key to cancel...");
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
}
