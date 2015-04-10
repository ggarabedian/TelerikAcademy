using System;
using System.Net;

/*
Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.    
 */

class DownloadFile
{
    static void Main()
    {
        try
        {
            WebClient downloadClient = new WebClient();
            downloadClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "NinjaPicture.png");
            Console.WriteLine("Image was downloaded successfully and stored in the project directory.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}

