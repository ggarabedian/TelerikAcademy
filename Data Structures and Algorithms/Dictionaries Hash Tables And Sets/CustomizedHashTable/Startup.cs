﻿namespace CustomizedHashTable
{
    /*
    04. Implement the data structure hash table in a class HashTable<K,T>. Keep the data in array of lists of key-value 
    pairs (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16. When the hash table load runs over 75%, perform 
    resizing to 2 times larger capacity. Implement the following methods and properties:
    Add(key, value)
    Find(key)->value
    Remove(key)
    Count
    Clear()
    this[]
    Keys
    Try to make the hash table to support iterating over its elements with foreach.
    Write unit tests for your class.
    */
    public class Startup
    {
        public static void Main()
        {
            var table = new CustomHashTable<int, string>();

            for (int i = 0; i < 30; i++)
            {
                table.Add(i, i.ToString());
            }

            System.Console.WriteLine(table);
            System.Console.WriteLine(table.Count);
        }
    }
}
