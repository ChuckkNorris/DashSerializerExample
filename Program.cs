using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace DashSerializer {
    class Program {

        static void Main(string[] args) {
            string inputFilePath = "./ExampleInput";
            string outputFilePath = "./ExampleOutput";
            if (args.Length > 0) inputFilePath = args[0];
            if (args.Length > 1) outputFilePath = args[1];
            UrlEncodeAndDecodeJsonFileAsync(inputFilePath, outputFilePath).GetAwaiter().GetResult();
            Console.ReadKey();
        }

        private static async Task UrlEncodeAndDecodeJsonFileAsync(string inputFileName, string outputFileName) {
            string inputJsonFilePath = $"{inputFileName}.json";
            string outputEncodedJsonFilePath = $"{outputFileName}-encoded.json";
            string outputDecodedJsonFilePath = $"{outputFileName}-decoded.json";

            Console.WriteLine($"Encoding JSON File... {inputJsonFilePath}");
            string inputFileJson = await FileHelpers.ReadFileAsync(inputJsonFilePath);
            string encodedJson = new JsonEditor(inputFileJson)?.UrlEncodeStrings();
            await FileHelpers.WriteFileAsync(outputEncodedJsonFilePath, encodedJson, shouldDelete: true);
            Console.WriteLine($"Successfully Encoded File to here... {outputEncodedJsonFilePath}");

            Console.WriteLine($"Decoding JSON File... {outputEncodedJsonFilePath}");
            string encodedJsonFromFile = await FileHelpers.ReadFileAsync(outputEncodedJsonFilePath);
            string decodedJson = new JsonEditor(inputFileJson)?.UrlDecodeStrings();
            await FileHelpers.WriteFileAsync(outputDecodedJsonFilePath, decodedJson, shouldDelete: true);
            Console.WriteLine($"Successfully Decoded File to here... {outputDecodedJsonFilePath}");
        }

    }
}
