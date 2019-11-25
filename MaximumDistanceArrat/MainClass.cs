using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumDistanceArrat
{
    public class MainClass
    {

        public int MIN(int a, int b)
        {
            if (a > b)
                return b;
            else
                return a;

        }

        public int MAX(int a , int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public int MaximumDistance(List<int> A)
        {

            int[] arr = new int[A.Count];

            for(int i=0;i<A.Count;i++)
            {
                arr[i] = A[i];
            }


            int[] LMin = new int[arr.Length];
            int[] RMax = new int[arr.Length];

            int n = arr.Length;
            Console.WriteLine("Length of array" + n);

            LMin[0] = arr[0];
            for(int i=1; i<n; i++)
            {
                LMin[i] = MIN(LMin[i - 1], arr[i]);
            }


            RMax[ n-1 ] = arr[ n-1 ];
            for(int j = n - 2; j >=0; j--)
            {
                RMax[j] = MAX(arr[j],RMax[j + 1]);
            }

            for(int k = 0; k < n; k++)
            {
                Console.Write(LMin[k]+" ");
            }
            Console.WriteLine(" ");

            for (int k = 0; k < n; k++)
            {
                Console.Write(RMax[k] + " ");
            }

            int _i = 0, _j = 0, maxDiff = -1;
            while(_i<n && _j < n)
            {
                if(LMin[_i] < RMax[_j])
                {
                    maxDiff = MAX(maxDiff, _j - _i);
                    _j = _j + 1;
                }
                else
                {
                    _i = _i + 1;
                }
            }

            return maxDiff;
            
            
        }
    }
}
