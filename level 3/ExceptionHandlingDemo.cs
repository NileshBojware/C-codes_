using System;

namespace ExceptionPrograms
{
    class ExceptionHandlingDemo
    {
        static void Main()
        {
            try
            {
                int a = int.Parse("abc");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}