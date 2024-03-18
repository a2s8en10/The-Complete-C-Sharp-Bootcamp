using System;

namespace Properties_With_Set_And_Get
{
    public class student
    {
        private int _stdid;
        private string _stdname;
        private int _stdage;

        public int Id 
        {
            set 
            { 
                if (value <= 0)
                {
                    Console.WriteLine("ID is not Zero and negetive..");
                }
                else
                {
                    this._stdid = value;
                }
            }
            get 
            {
                return this._stdid;
            }
        }
        //public int Age
        //{
        //    set { this.age = value; }
        //    get { return age; }
        //}
        //public string Name
        //{
        //    set { this.name = value; }
        //    get { return name; }
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student sub = new student();
            //student.Age = 20;
            //student.Name = "Anurag sahu";
            sub.Id = 3;

            Console.WriteLine(sub.Id);

            //Console.WriteLine("Id is " +student.Id);
            //Console.WriteLine("Age is "+ student.Age);
            //Console.WriteLine("Name is " + student.Name);

            Console.ReadLine();

        }
    }
}
