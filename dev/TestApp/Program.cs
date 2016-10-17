using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace TestApp
{
    class Program
    {
        private const string _mikTEXRegistryPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\BTS Products\MikTEX";
        public static string MikTEXPortablePath
        {
            get
            {
                try
                {
                    var path = (string)Registry.GetValue(_mikTEXRegistryPath, "InstallDir", null);
                    if (string.IsNullOrEmpty(path))
                        throw new MikTexInstallationException();
                    return path;

                }
                catch (Exception e)
                {
                    throw new MikTexInstallationException(e);
                }
            }
        }

        static int Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine($"A command line arg {arg}");
            }

            Console.WriteLine($"MikText is installed: {MikTEXPortablePath}");

            var returnCode =  runCompiler(Environment.CurrentDirectory).Result;

            return returnCode;
        }

        private static Task<int> runCompiler(string workingDirectory)
        {
            return Task.Run(() =>
            {
                // Use ProcessStartInfo class
                var startInfo = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    UseShellExecute = true,
                    FileName = Path.Combine(MikTexExecutablePath, "texife.exe"),
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = "--help",
                    WorkingDirectory = workingDirectory
                };

                using (var exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                    return exeProcess.ExitCode;
                }
            });
        }

        public static string MikTexExecutablePath => Path.Combine(MikTEXPortablePath, "miktex", "bin");
    }

    public class MikTexInstallationException : Exception
    {
        public MikTexInstallationException()
        {
        }

        public MikTexInstallationException(Exception exception)
        {

        }
    }


}
