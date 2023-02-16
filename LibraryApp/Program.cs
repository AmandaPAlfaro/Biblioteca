using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryApp
{
    public  class Program
    {
        static void Main(string[] args)
        {
            var jsonStringPath = "C:\\Users\\ASUS\\source\\repos\\LibraryApp\\ShelfContainer\\Quijote.json";
            var jsonContent = File.ReadAllText(jsonStringPath);
            var quijote = JsonConvert.DeserializeObject<Book>(jsonContent);

            var bible = new Book("Many Authors", "La Biblia", 1800, "Vaticano");

            var bibleSerialized = JsonConvert.SerializeObject(bible);
            File.WriteAllText("C:\\Users\\ASUS\\source\\repos\\LibraryApp\\ShelfContainer\\Bible.json", bibleSerialized);
        }
    }
}
