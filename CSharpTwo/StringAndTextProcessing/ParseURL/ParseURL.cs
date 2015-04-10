using System;

/*
Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it 
the [protocol], [server] and [resource] elements.
*/

class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL adress: ");
        string input = Console.ReadLine();

        Uri uri = new Uri(input);
        string protocol = uri.Scheme;
        string server = uri.Host;
        string resource = uri.AbsolutePath;

        Console.WriteLine("[protocol] = {0} \n[server] = {1} \n[resource] = {2}", protocol, server, resource);
    }
}

