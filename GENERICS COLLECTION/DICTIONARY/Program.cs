using System;
using System.Collections.Generic;

namespace DICTIONARY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // incomplete code 
            employee myemp = new employee();

            Dictionary<string,string> mydict = new Dictionary<string,string>();
            mydict.Add("name","Anurag");
            mydict.Add("id","0198CS221024");
            mydict.Add("state","mp");
            mydict.Add("degiganation","operator");

            //Console.WriteLine(mydict["name"]);

            foreach (KeyValuePair<string,string> item in mydict)
            {
                Console.WriteLine("key is : " + item.Key + " " + "value is : " + item.Value );
            }
            //foreach(string key in mydict.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //foreach(string value in mydict.Values)
            //{
            //    Console.WriteLine(value);
            //}
            Console.ReadLine();
        }
    }
}
