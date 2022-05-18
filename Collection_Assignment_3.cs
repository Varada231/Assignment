// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;
using System.Collections.Generic;
 
class GFG {
 
    // Main Method
    static public void Main()
    {
 
        // Creating a linkedlist
        // Using LinkedList class
        LinkedList<String> my_list = new LinkedList<String>();
 
        // Adding elements in the LinkedList
        // Using AddLast() method
        my_list.AddLast("Zoya");
        my_list.AddLast("Shilpa");
        my_list.AddLast("Rohit");
        my_list.AddLast("Rohan");
        my_list.AddLast("Juhi");
       
 
        Console.WriteLine("Employee in the company:");
 
       //Display the list of employee 
        foreach(string str in my_list)
        {
            Console.WriteLine(str);
        }
        //Added new Employee
          my_list.AddLast("Varada");
          Console.WriteLine("Updated Employee in the company:");
          
         foreach(string str in my_list)
        {
            Console.WriteLine(str);
        }
          Console.WriteLine("Total Employee in the list");
         Console.WriteLine(my_list.Count);
        
        
    }
}