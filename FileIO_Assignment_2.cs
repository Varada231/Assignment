// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
  class Tutorial
  {
   static void Main(string[] args)
   {
    String path = @"D:\testing.txt";
    //File Read
    using (StreamReader sr = File.OpenText(path))
    {
     String s = "";

     while ((s = sr.ReadLine()) != null)
     {
      Console.WriteLine(s);
     }
    }
    //File Write
    using (StreamWriter sr = File.AppendText(path))
    {
     sr.WriteLine("3 - .Net");
     sr.Close();

     Console.WriteLine(File.ReadAllText(path));
    }
   Console.ReadKey();
  }
 }
}