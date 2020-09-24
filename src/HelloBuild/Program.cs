using System;
using System.Reflection;
using System.Diagnostics;

namespace HelloBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello AppVeyor: branch testing");
            Console.WriteLine($"Assem Version: {AssemblyVersion}");
            Console.WriteLine($"File Version: {FileVersion}");
            Console.WriteLine($"Product Version: {ProductVersion}");

            Console.WriteLine("Press key to exit");
            Console.ReadKey();
        }

        private static string AssemblyVersion
            => Assembly.GetExecutingAssembly()
                    .GetName().Version.ToString();

        private static string FileVersion =>
            FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion; 

        private static string ProductVersion =>
            FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
    }
}
