using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using CsvFile.Model;
using CsvHelper;

namespace CsvFile
{
    internal class Register
    {
        static void scriviCsv<T>(List<T> lista,string path)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(lista);
            }
        }     
        static void print(string path)
        {
            FileInfo fi = new FileInfo(path);
            StreamReader sr = fi.OpenText();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        } 
        static void Main(string[] args)
        {
            string Logpath = "D:\\C#\\CorsoC#\\CsvFile\\Log.csv";
            string PersonPath = "D:\\C#\\CorsoC#\\CsvFile\\Person.csv";

            var listaPersone = new List<Person>()
            {
                new Person{FirstName = "aldo", IsAlive = true},
                new Person{FirstName = "giovanni" ,IsAlive = true},
                new Person{FirstName = "giacomo", IsAlive = true}
            };

            var logList = new List<Log>()
            {
                new Log{ ErrorCode = 404, Message = "not found", timeOfEvent = DateTime.Now },
               
            };

            scriviCsv<Person>(listaPersone, PersonPath);
            scriviCsv<Log>(logList, Logpath);

            print(PersonPath);
            Console.WriteLine();
            print(Logpath);     
        }
    }
}
