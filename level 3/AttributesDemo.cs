using System;

namespace AdvancedPrograms
{
    [Obsolete("Old Method")]
    class Demo
    {
        public void Show(){}
    }

    class AttributesDemo
    {
        static void Main()
        {
            Demo d = new Demo();
            d.Show();
        }
    }
}