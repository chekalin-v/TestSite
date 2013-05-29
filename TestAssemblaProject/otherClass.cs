using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestAssemblaProject
{
    class OtherClass
    {
        public int OpA { get; set;}
        public int OpB { get; set; }
        public OtherClass()
        { 
            OpA = 1;
            OpB = 2;
        }
        public void ShowSum()
        {
            Console.WriteLine("Sum of ops equals {0}",OpA+OpB);
        }
        public void ShowDiff()
        {
            Console.WriteLine("Diff of ops equals {0}", OpB-OpA);
        }
    }
}
