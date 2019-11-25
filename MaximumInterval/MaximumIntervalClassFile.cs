using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumInterval
{
    public class Interval
    {
        public int start { get; set; }
        public int end { get; set; }


        public Interval(int _start, int _end)
        {
            start = _start;
            end = _end;
        }
    }

    public class MaximumIntervalClass
    {

        public List<Interval> sortItems(List<Interval> A, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (A[j].start > A[i].start)
                    {
                        Interval temp = A[j];
                        A[j] = A[i];
                        A[i] = temp;


                    }
                }
            }

            return A;

        }
    }
}
