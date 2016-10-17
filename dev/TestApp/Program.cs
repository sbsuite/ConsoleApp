using System;
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


            return 0;
        }
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
