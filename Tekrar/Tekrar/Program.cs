using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Using Array.Sort for custom type array
            //Person p1 = new Person("Fikret", 25);
            //Person p2 = new Person("Kenan", 26);
            //Person p3 = new Person("Kamran", 30);
            //Person p4 = new Person("Miri", 21);
            //Person[] people = { p3, p1, p2, p4 };

            //Array.Sort(people);
            //foreach (Person p in people)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Task
            //string word = "Hello";
            //Console.WriteLine(word.CustomReplace('l','a'));

            //int[] arr = { 10, 20, 30, 10 };
            //Console.WriteLine(arr.GetCount(10));

            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 2, 4, 6, 8, 10 };
            Console.WriteLine(arr1.GetSameValue(arr2));
            #endregion
        }
    }

    #region Using Array.Sort for custom type array
    class Person:IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }

        public int CompareTo(object obj)
        {
            return this.Age.CompareTo(((Person)obj).Age);
        }
    }
    #endregion


}
