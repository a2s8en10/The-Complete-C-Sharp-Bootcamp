using System;
using System.Collections;

namespace COLLECTIONS_ARRAYLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            //// -------- check capacity its means Length 
            //Console.WriteLine(list.Capacity);

            // -------- any item Add in Arraylist 
            list.Add(1);
            list.Add("Anurag");
            list.Add(false);
            list.Add(23.34);
            list.Add(23.324);
            Console.WriteLine(list.Capacity);

            foreach(object item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            // ------- insert the value in middel array  list.Insert(index,value);

            list.Insert(2,"sahu");
            foreach (object item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // -------- Remove the value in middel array  list.Remove(value); AND list.RemoveAt(index);

            list.Remove("sahu");
            foreach (object item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.RemoveAt(1);
            foreach (object item in list)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
