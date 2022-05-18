// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;
using System.Collections; 

public class HelloWorld
{
    public static void Main(string[] args)
    {
       ArrayList employeeList = new ArrayList();  
            employeeList.Add("Sandeep");  
            employeeList.Add("Raviendra");  
            employeeList.Add("Varada");  
            for (int i = 0; i < employeeList.Count; i++)  
            {  
                string arrayItem = string.Format($"Employee Name is {employeeList[i]}");  
                Console.WriteLine(arrayItem);  
            }  
            Console.Read();  
    }
}