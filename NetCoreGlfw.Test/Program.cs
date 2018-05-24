using System;

namespace NetCoreGlfw.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            new TestExample().Main(null);
            new TestClipboard().Main(null);
            new TestCursor().Main(null);
            new TestEmpty().Main(null);
            new TestGamma().Main(new string[] { });
            new TestGammaRamp().Main(new string[] { });
            new TestIcon().Main(new string[] { });
            new TestIconify().Main(new string[] { });
            new TestJoysticks().Main(new string[] { });
            new TestMonitors().Main(new string[] { });
            new TestMSAA().Main(new string[] { });
            new TestReopen().Main(new string[] { });
            new TestSharing().Main(new string[] { });
            new TestTearing().Main(new string[] { });
            new TestTimeout().Main(new string[] { });
            new TestTitle().Main(new string[] { });
            new TestWindows().Main(new string[] { });
            new TestEvents().Main(new string[] { });
        }
    }
}
