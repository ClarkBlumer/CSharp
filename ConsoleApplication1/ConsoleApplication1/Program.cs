using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}
}

// class sample
// {
// public int i;
// void display()
// {
// Console.WriteLine(i);
// }
// }
// class sample1 : sample
// {
//public int j;
// public void display()
// {
// Console.WriteLine(j);
// }
// }
// class Program
// {
// static void Main(string[] args)
// {
// sample1 obj = new sample1();
// obj.i = 1;
// obj.j = 2;
// obj.display();
// Console.ReadLine();
//}
//}

class sample
 {
 int i = 10;
 int j = 20;
 public void display()
 {
 Console.WriteLine("base method ");
 }
 }
 class sample1 : sample
 {
 public int s = 30;
 }
 class Program
 {
 static void Main(string[] args)
 {
 sample1 obj = new sample1();
 Console.WriteLine("{0}, {1}, {2}", obj.i, obj.j, obj.s);
 obj.display();
 Console.ReadLine();
 }
 }