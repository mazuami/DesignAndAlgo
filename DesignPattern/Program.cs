using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibonacciMemo;
using MaximumDistanceArrat;
using UnsortedSubArray;
using AdapterDesignPattern;
using TortoiseHareAlgorithm;
using PigeonHoleAlgorithm;
using MissingInteger;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {  
            /******
            Memoization mn = new Memoization();
            Console.WriteLine(mn.fibonaci(40));
            Console.ReadLine();
            */

            /*
            MainClass mC = new MainClass();
            List<int> testArr = new List<int>();
            testArr.Add(1);

            
            int a=mC.MaximumDistance(testArr);
            Console.WriteLine(a);
            

            UnsortedArray UA = new UnsortedArray();

            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(5);
            a.Add(6);
            a.Add(13);
            a.Add(15);
            a.Add(16);
            a.Add(17);
            a.Add(13);
            a.Add(13);
            a.Add(15);
            a.Add(17);
            a.Add(17);
            a.Add(17);
            a.Add(17);
            a.Add(17);
            a.Add(19);
            a.Add(19);

            foreach (int x in UA.calculateDistance(a))
            {
                Console.WriteLine(x);
            }
            
            Console.WriteLine("Old Era");
            var emp_Old = new EmployeeController();
            foreach(var i in emp_Old.getEmployeeList()){
                Console.WriteLine(i);
            }
            IEmployee emp = new EmployeeAdapterClass();
            Console.WriteLine("New Era");
            foreach (var i in emp.getEmployeeList())
            {
                Console.WriteLine(i);
            }
            */

            /*------Design Pattern -----------

            EmployeeController EC = new EmployeeController();
            Console.WriteLine(EC.getEmployeeList());
            IEmployee emp = new EmployeeAdapterClass();
            Console.WriteLine(emp.getEmployeeList());


            ---------------------------------------*/


            /*--------- finding Duplicates in an Array in Linear complexity with Tortoise-Hare Algorithm-----------------

            FindingDuplicateInArray FDA = new FindingDuplicateInArray();
            List<int> A = new List<int>();
            A.Add(3);
            A.Add(4);
            A.Add(1);
            A.Add(2);
            A.Add(0);

            FDA.repeatedNumber(A);
            /*--------------------------------------*/

            /*-----------Sorting an Array with Pegion Hole Algorithm------------------


            List<int> A = new List<int>();
            A.Add(8);
            A.Add(3);
            A.Add(2);
            A.Add(7);
            A.Add(4);
            A.Add(6);
            A.Add(8);

            PegionHoleAlgo PGA = new PegionHoleAlgo();
            Console.WriteLine(PGA.sort_PegionHole(A));
            ------------------------------------------------------------------*/

            /*------------------Missing integer ------------------------
            List<int> A = new List<int>();
            A.Add(1);
            A.Add(2);
            A.Add(3);
            A.Add(4);
            A.Add(5);
            A.Add(6);
            
            FindTheMissingNumber fm = new FindTheMissingNumber();
            Console.WriteLine(fm.MissingNumber(A));

            Console.ReadLine();

            -----------------------------------------------------------*/

            /*---------------------Merge Intervals ----------------------*/

            List<MaximumInterval.Interval> A = new List<MaximumInterval.Interval>();
            // MaximumInterval.Interval intv = new MaximumInterval.Interval();
            A.Add(new MaximumInterval.Interval(1, 2));
            A.Add(new MaximumInterval.Interval(8, 10));
            A.Add(new MaximumInterval.Interval(3, 4));
            A.Add(new MaximumInterval.Interval(12, 16));
            A.Add(new MaximumInterval.Interval(6, 7));
            A.Add(new MaximumInterval.Interval(4, 9));
            A.Add(new MaximumInterval.Interval(5, 6));

            MaximumInterval.MaximumIntervalClass opt = new MaximumInterval.MaximumIntervalClass();
            opt.sortItems(A, 7);
        }
    }
}
