using System;

namespace AdvancedPrograms
{
    class MyCollection
    {
        private int[] arr = new int[5];

        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
    }

    class IndexerDemoProgram
    {
        static void Main()
        {
            MyCollection obj = new MyCollection();
            obj[0] = 10;
            Console.WriteLine(obj[0]);
        }
    }
}