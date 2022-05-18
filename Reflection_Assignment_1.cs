// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;
using System.Reflection; 

public class Program
{
    public static void Main(string[] args)
    {
        
           Console.Write("Enter the Name to Explore:");  
          string typNames = Console.ReadLine();  
  
           Type t = Type.GetType(typNames);  
    FieldInvestigation(t);  
    MethodInvestigation(t);
            Console.Write("Enter External Assembly:");  
            string typName = Console.ReadLine();  
            try  
            {  
                Assembly asm = Assembly.Load(typName);  
                DispalyAssembly(asm);  
            }  
            catch  
            {  
                Console.WriteLine("Can't Load Assembly");    
            }  
            Console.ReadKey();    
        }  
  
        static void DispalyAssembly(Assembly a)  
        {  
            Console.WriteLine("*******Contents in Assembly*********");  
            Console.WriteLine("Information:{0}",a.FullName);  
            Type[] asm = a.GetTypes();  
            foreach (Type tp in asm)  
            {  
                Console.WriteLine("Type:{0}", tp);  
            }  
        } 
        
        static void FieldInvestigation(Type t)  
{  
    Console.WriteLine("*********Fields*********");  
    FieldInfo [] fld= t.GetFields();   
    foreach(FieldInfo f in fld)  
    {  
        Console.WriteLine("-->{0}", f.Name);   
    }  
}  
  
static void MethodInvestigation(Type t)  
{  
    Console.WriteLine("*********Methods*********");  
    MethodInfo [] mth = t.GetMethods();  
    foreach (MethodInfo m in mth)  
    {  
        Console.WriteLine("-->{0}", m.Name);  
    }  
}  
   
}  
    
