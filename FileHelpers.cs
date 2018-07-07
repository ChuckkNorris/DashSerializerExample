using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace DashSerializer {
    class FileHelpers {

        public static async Task<string> ReadFileAsync(string filePath) {
            using (StreamReader r = new StreamReader(filePath))
                return await r.ReadToEndAsync();
        }

        public static async Task WriteFileAsync(string filePath, string fileText = "{}", bool shouldDelete = false) {
            if (shouldDelete)
                File.Delete(filePath);
            await File.AppendAllTextAsync(filePath, fileText);
        }

    }
}
