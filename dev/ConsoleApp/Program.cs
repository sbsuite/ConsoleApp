using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using node1_1;

namespace ConsoleApp
{
   class Program
   {
      static void Main(string[] args)
      {
         MainAsync().Wait();
      }

      static async Task MainAsync()
      {
         try
         {

//            var model = new Model();
//            var modelExport = new node1_1.ModelExportService();

         }
         catch (Exception ex)
         {
            // Handle exceptions.
         }
      }

   }
}
