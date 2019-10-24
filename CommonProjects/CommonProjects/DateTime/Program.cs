using System;

namespace DateTimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string empty = String.Empty;
            Console.WriteLine(empty);
            Console.WriteLine(empty == "");

            int compareResult1 = string.Compare("A1", "B");
            int compareResult2 = string.Compare("AAAABBBBbbbbAAAA", "aaaaBbbbbbbbaaaa",
                StringComparison.OrdinalIgnoreCase);
            string join = string.Join(", ", new[] { "A", "B", "C", "D" });
            string join2 = string.Join("", new[] { 1, 2, 3, 4, 5 });
            bool isEmpty = string.IsNullOrEmpty("AB");

            string value = null;
            bool isEmpty2 = string.IsNullOrEmpty(value);



            string name = ";Ro;man;;;    ,,    ,m";
            string name2 = "123Maxim123";

            Console.WriteLine(name.Length);
            Console.WriteLine(name.Contains("Man"));
            Console.WriteLine(name.EndsWith("AN", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(name.IndexOf("m"));
            Console.WriteLine(name.Replace("o", "EEE"));
            Console.WriteLine(name.Remove(2));
            Console.WriteLine(name.Remove(1, 2));
            Console.WriteLine(name.Insert(0, "!!!"));
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Trim(new[] { ';', ',',' ' }));
            Console.WriteLine(name2.Substring(3, 5));
            Console.WriteLine(name.LastIndexOf("m"));



            Console.ReadLine();
        }
    }
}
