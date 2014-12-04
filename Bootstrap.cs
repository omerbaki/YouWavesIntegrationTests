using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWavesIntegrationTests.Tests;

namespace YouWavesIntegrationTests
{
    class Bootstrap
    {
        public static IUnityContainer CreateContainer()
        {
            IUnityContainer container = new UnityContainer();

            //container.AddNewExtension<FrameworkExtendedContainer>();
            container.RegisterType<ITest, IsramarImageAnalyzerTests>("IsramarImageAnalyzerTests");
            container.RegisterType<IEnumerable<ITest>, ITest[]>();
            container.RegisterType<ITestsRunner, TestsRunner>();

            return container;
        }
    }
}
