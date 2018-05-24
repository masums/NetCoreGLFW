namespace NetCoreGlfw.Test
{
    using Glfw3;
    using System;

    internal class TestBase
    {
        internal static void ErrorCallback(Glfw.ErrorCode error, string description)
        {
            Log("Error({0}): {1}\n", error, description);
        }

        internal static void Init()
        {
            Glfw.ConfigureNativesDirectory("Native");
            Glfw.SetErrorCallback(ErrorCallback);
        }

        internal static void Log(string str)
        {
            Console.WriteLine(str);
        }

        internal static void Log(string str, params object[] values)
        {
            Console.WriteLine(string.Format(str, values));
        }
    }
}
