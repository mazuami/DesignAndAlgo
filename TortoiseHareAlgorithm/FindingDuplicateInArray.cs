using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseHareAlgorithm
{
    // This is an implementation of Floyd Tortois Hare Algorithm for detecting cycle in a loop. This can be be used to find if
    // an array contains any repeated elements or not 
    // The Idea 

    public class FindingDuplicateInArray 
    {

        public int repeatedNumber(List<int> A)
        {
            int t = A[0];
            int h = A[A[0]];

            while (t != h)
            {
                t = A[t];
                h = A[A[h]];
            }

//            Console.WriteLine("tortoise" + t);
//            Console.WriteLine("hare" + h);
            h = 0;

            while(t != h)
            {
                t = A[t];
                h = A[h];
            }

            return h;
        }
        
    }
}
