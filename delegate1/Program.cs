using System;

namespace delegate1
{
    delegate DateTime MyDelegate(DateTime dt, int n);

    class MyClass1
    {
        public DateTime Calc(DateTime d, int n){
            return d.AddDays(n);
        }
    }

    class MyClass2
    {
        public DateTime Calc(DateTime d, int n)
        {
            return d.AddHours(n);
        }
    }

    class MyClass3
    {
        public DateTime Calc(DateTime d, int n)
        {
            return d.AddMinutes(n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 mc1 = new MyClass1();
            MyClass2 mc2 = new MyClass2();
            MyClass3 mc3 = new MyClass3();
            
            MyDelegate md = new MyDelegate(mc1.Calc);
            DateTime dt = DateTime.Now;

            DateTime mydate;

            mydate = md(dt, 100);
            Console.WriteLine("今日から100日後は、{0}です", mydate.ToShortDateString());

            md = new MyDelegate(mc2.Calc);
            mydate = md(dt, 24);
            Console.WriteLine("今から24時間後は、{0}です", mydate);

            md += new MyDelegate(mc3.Calc);
            Console.WriteLine("今から100時間後は、{0}です", mydate);
            mydate = md(dt, 100);
            Console.WriteLine("今から100分後は、{0}です", mydate);
        }
    }
}
