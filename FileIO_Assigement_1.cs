// Online C# Editor for free
using System;
using System.IO;
 
public class Example
{
    public static void Main()
    {
        string rootdir = @"C:\Program";
 
        // get the list of files
        string[] files = Directory.GetFiles(rootdir);
        Console.WriteLine(String.Join(Environment.NewLine, files));
 
        // get the list of directories
        string[] dirs = Directory.GetDirectories(rootdir);
        Console.WriteLine(String.Join(Environment.NewLine, dirs));
    }
}