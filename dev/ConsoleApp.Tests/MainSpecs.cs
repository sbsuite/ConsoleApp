using NUnit.Framework;

namespace ConsoleApp.Tests
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

         Assert.IsTrue(true);
      }
   }
}