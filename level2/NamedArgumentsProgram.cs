using System;

namespace MethodsPrograms
{
    class NamedArgumentsProgram
    {
        static void Main()
        {
            Display(age:20, name:"Nilesh");
        }

        static void Display(string name, int age)
        {
            Console.WriteLine($"{name} is {age} years old");
        }
    }
}