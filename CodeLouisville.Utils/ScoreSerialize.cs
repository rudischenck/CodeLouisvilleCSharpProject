using CodeLouisville.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisville.Utils
{
    public static class ScoreSerialize
    {
        public static void SerializeScoresToFile (List<Scoring> scores, string fileName)
        {
            Console.WriteLine("Serializing scores to file...");
            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, scores);
            }
            Console.WriteLine("Serializing success!");
        }

    }
}
