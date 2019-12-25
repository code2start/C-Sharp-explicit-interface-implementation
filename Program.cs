using System;

namespace explicit_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();
            IControl c = sc;
            ISurface s = sc;
            //the following lines all call the same method
            c.Paint();
            s.Paint();
            sc.Paint();
        }
    }
}
