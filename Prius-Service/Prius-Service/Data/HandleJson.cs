using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Prius_Service.Data
{
    public class HandleJson
    {
        public HandleJson()
        {
        }

        public void WriteToJson(object obj, string fileName, string filePath)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            var jsonString = JsonSerializer.Serialize(obj, options);

            try
            {
                File.WriteAllText(Path.Combine(filePath, fileName), jsonString, Encoding.UTF8);
            } catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(filePath);
                File.WriteAllText(Path.Combine(filePath, fileName), jsonString, Encoding.UTF8);
            }
        }

        public JsonDocument ReadFromJson(string path)
        {
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(path);

                var result = JsonDocument.Parse(jsonString, new JsonDocumentOptions { CommentHandling = JsonCommentHandling.Skip });

                return result;
            }

            return null;
        }
    }
}
