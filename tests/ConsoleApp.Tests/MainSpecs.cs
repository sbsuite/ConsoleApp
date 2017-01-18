﻿using System;
using ConsoleApp;
using Microsoft.Win32;
using NUnit.Framework;

namespace Tests.ConsoleApp
{
   [TestFixture]
   public class MainSpecs
   {
      [Test]
      [Category("ReportingTest")]
      public void this_is_a_reporting_test()
      {
         Assert.IsTrue(true);
      }

      [Test]
      [Category("IntegrationTest")]
      public void this_is_an_integrations_test()
      {
         Assert.IsTrue(true);
      }

      [Test]
      public void this_is_a_standard_test()
      {
         var testClass = new TestClass();
         Assert.IsTrue(testClass.True());
      }

      [Test]
      [Category("Bug")]
      public void this_is_the_path_of_the_install_read_from_registry()
      {
         var path = MikTEXPortablePath;
         Console.WriteLine($"Registry: MikText is installed: {path}");
         Assert.IsFalse(string.IsNullOrEmpty(path));
      }

      [Test]
      [Category("Bug")]
      public void this_is_the_path_of_the_install_read_from_environment()
      {
         var path = Environment.GetEnvironmentVariable("MIK_TEX_INSTALL_DIR");
         Console.WriteLine($"ENV: MikText is installed: {path}");
         Assert.IsFalse(string.IsNullOrEmpty(path));
      }

      private const string _mikTEXRegistryPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\BTS Products\MikTEX";

      public static string MikTEXPortablePath
      {
         get
         {
            try
            {
               return (string) Registry.GetValue(_mikTEXRegistryPath, "InstallDir", null);
            }
            catch (Exception e)
            {
               return null;
            }
         }
      }
   }
}