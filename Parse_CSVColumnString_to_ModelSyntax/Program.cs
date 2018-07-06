using System;

namespace Parse_CSVColumnString_to_ModelSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string inputString = Console.ReadLine();

                ConvertColumnToModel(inputString);
            }
        }

        public static string ConvertColumnToModel(string data)
        {
            var properties = data.Split(",");
            string result;
            foreach (var item in properties)
            {
                result = item.Replace("\"", "");
                result = "string " + result + " { get; set;}";

                Console.WriteLine(result);
                result = "";
            }

            return "";
        }
    }
}
