using IsramarWaveAnalyzer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouWavesIntegrationTests.Tests
{
    class IsramarImageAnalyzerTests : ITest
    {
        public async Task RunTests()
        {
            // Run over all isramar images 
            var imagesPaths = Directory.GetFiles(@"TestsResources\IsramarImages");

            foreach (var imagePath in imagesPaths)
            {
                var imageBytes = await GetImageBytes(imagePath);

                var isramarImageAnalyzer = new IsramarImageAnalyzer();
                var waveHeight = isramarImageAnalyzer.GetWaveHeight(imageBytes);

                Console.WriteLine(Path.GetFileName(imagePath) + " - " + waveHeight);
            }
        }

        private async Task<byte[]> GetImageBytes(string imagePath)
        {
            byte[] result;
            using (FileStream SourceStream = File.Open(imagePath, FileMode.Open))
            {
                result = new byte[SourceStream.Length];
                await SourceStream.ReadAsync(result, 0, (int)SourceStream.Length);
            }

            return result;
        }
    }
}
