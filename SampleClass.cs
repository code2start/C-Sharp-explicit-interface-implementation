using System;
using System.Collections.Generic;
using System.Text;

namespace explicit_interface
{
    class SampleClass : IControl, ISurface
    {
         void ISurface.Paint()
        {
            Console.WriteLine("Paint method in ISurface");
        }

        void IControl.Paint()
        {
            Console.WriteLine("Paint method in IControl ");
        }
    }
}
