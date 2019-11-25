using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsortedSubArray
{
    public class UnsortedArray
    {

        public List<int> calculateDistance(List<int> A)
        {
            List<int> subArray = new List<int>();
            int[] arr = new int[A.Count];

            for (int i = 0; i < A.Count; i++)
            {
                arr[i] = A[i];
            }
            int sizeArray = A.Count;
           

            int intArrayDist = -1;

            for (int i = 0; i < sizeArray -1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    intArrayDist = 1;
                }
            }


            if (intArrayDist == 1)
            {
                int _indlft = 0, _indRht = 0;

                for (int i = 0; i < sizeArray -1 ; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        _indlft = i;
                        break;
                    }
                }

                for (int j = sizeArray - 1; j >= 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        _indRht = j;
                        break;
                    }
                }

            //    cout << _indlft;
            //    cout << _indRht;

                int minLeft = arr[_indlft];
                for (int m = _indlft; m <= _indRht; m++)
                {
                    if (minLeft > arr[m])
                    {
                        minLeft = arr[m];
                    }
                }

                int maxRight = arr[_indRht];

                for (int n = _indlft; n <= _indRht; n++)
                {
                    if (maxRight < arr[n])
                    {
                        maxRight = arr[n];
                    }
                }


                int _indexMinLeft = 0;
                int _indexMaxRight = 0;

                for (int k = 0; k <= _indlft; k++)
                {
                    if (minLeft < arr[k])
                    {
                        _indexMinLeft = k;
                        break;
                    }
                }

                for (int l = _indRht; l <= sizeArray - 1; l++)
                {
                    if (maxRight > arr[l])
                    {
                        _indexMaxRight = l;
                    }
                }

                //       cout << "The minimum index - " << _indexMinLeft;
                //       cout << "The maximum index - " << _indexMaxRight;

          //  for(int q = _indexMinLeft; q <= _indexMaxRight; q++)
          //      {
                    subArray.Add(_indexMinLeft);
                    subArray.Add(_indexMaxRight);
          //      }

                return subArray;
            }

            else
            {
                subArray.Add(-1);
                return subArray;
            }
        }
    }
}
