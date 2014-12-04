using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace YouWavesIntegrationTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Bootstrap.CreateContainer();
            
            var testRunner = container.Resolve<ITestsRunner>();
            testRunner.Run();

            Console.ReadLine();
        }
    }
}
