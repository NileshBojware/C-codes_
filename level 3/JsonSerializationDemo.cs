using System;
using System.Text.Json;

namespace IOPrograms
{
    class Person { public string Name {get;set;} }

    class JsonSerializationDemo
    {
        static void Main()
        {
            Person p = new Person{ Name="Nilesh"};
            string json = JsonSerializer.Serialize(p);
            Console.WriteLine(json);
        }
    }
}