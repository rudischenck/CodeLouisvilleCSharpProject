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
        public static void SerializeGamesToFile (List<Game> games, string fileToWrite, out string serializeGamesOutput)
        {
            serializeGamesOutput = "Serializing games to following directory:\n" + fileToWrite;
            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileToWrite))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, games);
            }
            serializeGamesOutput += "\nSerializing success!";
        }

    }
}
