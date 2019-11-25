using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//---------------------------------------//
//-- sum of the array with the formula in - n(n+1)/2
//-- subtract the sum of all the remaining elements from the sum that we got in step one 


namespace MissingInteger
{

    public class FindTheMissingNumber
    {
        public int MissingNumber(List<int> A)
        {
            int sum = 0;
            int array_sum = 0;
            int missing_integer = 0;
            int count = A.Count;

            sum = (count * (count + 1)) / 2;

            bool allelementsame = false;

            for(int j=0;j<A.Count - 1; j++)
            {
                if(A[j] == A[j + 1])
                {
                    allelementsame = true;
                }
                else
                {
                    allelementsame = false;
                }
            }

            if (allelementsame == true)
            {

                missing_integer = A[0] + 1;
            }
            else
            {

                if (A.Count > 2)
                {
                    for (int i = 0; i < A.Count; i++)
                    {

                        if (A[i] >= 0)
                        {
                            array_sum = A[i] + array_sum;
                        }
                        else
                        {
                            missing_integer = -1;
                        }


                    }
                }
                else
                {
                    if (A[0] < 0)
                    {
                        missing_integer = 1;
                    }
                    else if (A[0] > 1)
                    {
                        missing_integer = A[0] + 1;
                    }
                }
            }
            if (missing_integer == 0)
            {
                if (sum != array_sum) {
                    missing_integer = sum - array_sum;
                    }
                else
                {
                    missing_integer = A[A.Count - 1] + 1;
                }
            }
            else if (missing_integer == -1)
            {
                missing_integer = 1;
            }
            else if(missing_integer > 0 && A[0]>0)
            {
                missing_integer = A[0] + 1;
            }


            return missing_integer;

        }
    }
 }

