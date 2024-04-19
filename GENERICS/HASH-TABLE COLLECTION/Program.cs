using System;
using System.Collections;

namespace HASH_TABLE_COLLECTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {"id",4},
                {"name","Anurag sahu"},
                {"age",23},
                {"phone no.",1234567890}
            };
            Console.WriteLine(ht["name"]);
            foreach (object key in ht.Keys)  // both are print keys and value
            {
                Console.WriteLine(key + ":" +ht[key]);
            }
            Console.WriteLine("number of hashtable key and value : "+ht.Count);

            /* Console.WriteLine("id".GetHashCode());  */// hash code are change 

            //Console.WriteLine(ht.Contains("id"));      // contains method use the value and ekys are present in hashtable
            //Console.WriteLine(ht.ContainsKey("name"));
            //Console.WriteLine(ht.ContainsKey("roll no."));
            //Console.WriteLine(ht.ContainsValue("Anurag sahu"));

            //ht.Remove("id");
            //Console.WriteLine("------------------");
            //foreach (object key in ht.Keys) 
            //{
            //    Console.WriteLine(key + ":" + ht[key]);
            //}

            //ht.Clear();
            //Console.WriteLine("------------------");
            //foreach (object key in ht.Keys)  // both are print keys and value
            //{
            //    Console.WriteLine(key + ":" + ht[key]);
            //}

            //foreach (object value in ht.value)    // all value print
            //{
            //    Console.WriteLine(value);
            //}    
            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(ht[key]);
            //}

            //foreach (object key in ht.Keys)    // all keys print
            //{
            //    Console.WriteLine(key);
            //}

            //ht.Add("id", 12);               // Add method
            //ht.Add("name", "Anurag sahu");
            //ht.Add("age",29);
            //ht.Add("phone number",1234567890);

            // Console.WriteLine(ht["name"]);

            Console.ReadLine();
        }
    }
}
