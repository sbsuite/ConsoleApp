using ConsoleApp;
using NUnit.Framework;

namespace Tests.ConsoleApp
{
   [TestFixture]
   public class MainSpecs
   {

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
   }
}