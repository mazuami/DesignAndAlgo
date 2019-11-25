using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciMemo
{
    public class Memoization
    {
        int[] cache = new int[100];

        public Memoization()
        {
            for (int i = 0; i < 100; i++)
            {
                cache[i] = -1;
            }

        }

        public int fibonaci(int n)
        {

            //initialization of cache//

            //check if the fib(n) value is present in the cache or not---
            
                if (n == 1 || n==0)
                {
                    
                    return 1;
                }

                else if( n== 2)
                {
                    
                    return 1;
                }
                else if(cache[n] != -1)
                {
                  return cache[n];
                }
                else
                {
                    cache[n] = fibonaci(n - 1) + fibonaci(n - 2);
                    return cache[n];
            }

        
                
        }


    }
}
