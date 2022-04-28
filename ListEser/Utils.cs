using Greet;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace Client
{
    public class Utils
    {
        
        public class Elenco<T> where T: class
        {   
            static int index = 10;
            T[] _data = new T[index]; 
            T entry = new();
            Dictionary<string, T> _dataList = new Dictionary<string, T>();
        
            public void AddItem(T item)
            {
               StringBuilder sb = new StringBuilder();
           
            IList<PropertyInfo> propertyInfos = typeof(T).GetProperties();

            if (includeHeaderLine)
            {
                //add line.
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    sb.Append(propertyInfo.Name).Append(",");
                }
                sb.Remove(sb.Length - 1, 1).AppendLine();
            }

            //add value 
            foreach (T obj in Objects)
            {               
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    sb.Append(MakeValueCsvFriendly(propertyInfo.GetValue(obj, null))).Append(",");
                }
                sb.Remove(sb.Length - 1, 1).AppendLine();
            }
            return sb.ToString();
            }

            public void Print()
            {
                var campi = entry.GetType().GetProperties();

                foreach (var prop in campi)
                {
                    Console.WriteLine(prop.Name);
                }
            }
        }
    }
}