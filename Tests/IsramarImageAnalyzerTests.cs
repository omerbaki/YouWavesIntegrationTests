using IsramarWaveAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouWavesIntegrationTests.Tests
{
    class IsramarImageAnalyzerTests : ITest
    {
        public async Task RunTests()
        {
            var isramarImageAnalyzer = new IsramarImageAnalyzer();
            isramarImageAnalyzer.GetWaveHeight(null);
        }
    }
}
