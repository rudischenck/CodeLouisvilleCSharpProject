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
    public static class GamesSerialize
    {
        public static void SerializeGamesToFile (List<Game> games, string fileName, out string serializeGamesOutput)
        {
            serializeGamesOutput = "Serializing games to file...";
            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, games);
            }
            serializeGamesOutput += "\nSerializing success!";
        }

    }
}
