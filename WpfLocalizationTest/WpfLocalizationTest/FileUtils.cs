using System;
using System.IO;
using System.Linq;

namespace WpfLocalizationTest
{
    public class FileUtils
    {
        private static readonly string LangFilePath = Path.Combine(Directory.GetCurrentDirectory(), "lang.acat");
        
        public static void save(Language language)
        {
            File.WriteAllText(LangFilePath, language.ToString());
        }

        public static Language read()
        {
            var line =  File.ReadAllLines(LangFilePath).First();
            return (Language)Enum.Parse(typeof(Language), line);
        }
    }
}