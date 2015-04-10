using System;
using System.IO;

/*
Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and 
prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
*/

class ReadFileContent
{
    static void Main()
    {
        Console.Write("Enter full path to the file: ");
        string path = Console.ReadLine();
        TryToReadFile(path);
    }

    static void TryToReadFile(string path)
    {
        try
        {
            string content = File.ReadAllText(path);
            Console.WriteLine("Content: ");
            Console.WriteLine(content);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine(ptle.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

