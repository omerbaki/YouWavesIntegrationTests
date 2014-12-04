using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWavesIntegrationTests.Tests;

namespace YouWavesIntegrationTests
{
    public interface ITestsRunner
    {
        Task Run();
    }

    class TestsRunner : ITestsRunner
    {
        private readonly IEnumerable<ITest> mTests;
        public TestsRunner(IEnumerable<ITest> tests)
        {
            mTests = tests;
        }

        public async Task Run()
        {
            foreach(var test in mTests)
            {
                await test.RunTests();
            }
        }
    }
}
