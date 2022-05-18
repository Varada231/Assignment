// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
  // Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;  
  
class linSearch  
{  
    public static void Main()  
    {  
        int[] a = new int[3];  
        Console.WriteLine("Enter number of elements you want to hold in the array ");  
        string s = Console.ReadLine();  
        int x = Int32.Parse(s);  
        Console.WriteLine("--------------------------------------------------");  
        Console.WriteLine("\n Enter array elements \n");  
        Console.WriteLine("--------------------------------------------------");  
  
        for (int i = 0; i < x; i++)  
        {  
            string s1 = Console.ReadLine();  
            a[i] = Int32.Parse(s1);  
        }  
       
        
        // Sort the values of the Array.  
        Array.Sort(a);  
        Console.WriteLine("--------------Sorted-------------------------");  
         for (int i = 0; i < x; i++)  
        {  
  
            Console.WriteLine($"Element {i + 1} is {a[i]}");  
        } 
  
        // Reverse the values of the Array.  
        Array.Reverse(a);  
        Console.WriteLine("-----------Reversed-------------------------------");  
        Console.WriteLine("----------------------------------------------");  
        for (int i = 0; i < x; i++)  
        {  
  
            Console.WriteLine($"Element {i + 1} is {a[i]}");  
        } 
        
        //Array Copy Method
        int[] arrTarget = new int[3];
        Array.Copy(a, arrTarget, 3);
        Console.WriteLine("Destination Array ...");
        foreach (int value in arrTarget) {
         Console.WriteLine(value);
        }
        //Array clear Method
        Array.Clear(a, 0, a.Length);
         Console.WriteLine("-----------Clear Array Value-------------------------------");  
        Console.WriteLine("----------------------------------------------");
         for (int i = 0; i < x; i++)  
        {  
  
            Console.WriteLine($"Element {i + 1} is {a[i]}");  
        } 
        
    }  
}  