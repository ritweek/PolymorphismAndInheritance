using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassB y = new ClassB();
            ClassA x = new ClassA();
            ClassB z = new ClassA();
            y.AAA(); y.BBB(); y.CCC();
            x.AAA(); x.BBB(); x.CCC();
            z.AAA(); z.BBB(); z.CCC();
            Console.ReadKey();

        }
    }
    public class ClassB
    {
        public void AAA()
        {
            Console.WriteLine("ClassB AAA");
        }
        public void BBB()
        {
            Console.WriteLine("ClassB BBB");
        }
        public void CCC()
        {
            Console.WriteLine("ClassB CCC");
        }
    }

    public class ClassA : ClassB
    {
        public void AAA()
        {
            Console.WriteLine("ClassA AAA");
        }
        public void BBB()
        {
            Console.WriteLine("ClassA BBB");
        }
        public void CCC()
        {
            Console.WriteLine("ClassA CCC");
        }
    }
}
