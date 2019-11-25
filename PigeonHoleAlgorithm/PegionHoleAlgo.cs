using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonHoleAlgorithm
{
    // 1) Find the min and max element within an array 
    // 2) Find range for the pegionHole array using the formula : max-min-1
    // 3) Make an array of items  with the length as range
    // 4) Loop through the unsorted array and insert into the  pegionHole at index a[i]-min
    // 5) Loop back from the pegion hole arrar and insert the items back to the original array
    // 6) Complexities in o(n+Range)

//Pending Test Case //

/*
  26329689, 41434935, 80022157, 25781981, 78410947, 95674876, 30464968, 
  43896783, 6628553, 13108711, 99947509, 2348691, 40031584, 48433971,
  97708913, 66558741, 69643585, 98688986, 6260123, 85036463, 56382112, 
  70340540, 22623656, 27653356, 9959023, 78933711, 70155015, 91075431, 
  46776411, 88597358, 46101018, 59267176, 43672197, 40261922, 97431622, 
  80791799, 42665817, 34603681, 4073869, 38115218, 60722158, 78745265,
  31497763, 94887351, 89206441, 16839521, 31531549, 23641850, 31869495,
  28837377, 23055945, 62591193, 87758649, 2608783, 17805956, 49040487,
  67288067, 35502363, 53397026, 81591886, 21619832, 37627986, 75031499, 
  86372231, 23401574, 98290323, 36474468, 99789030, 47042409, 45329473, 
  2002775, 56764758, 43602655, 56051262, 92804329, 77305420, 25641722,
  85355269, 27984104, 99063897, 85242758, 8310484, 84340016, 39609976, 
  6294678, 84731325, 65492554, 31483274, 68164416, 64126431, 24210662, 
  42566989, 16198999, 70109154, 41969425, 30663485, 41285199, 56387783,
  57256193, 13216112, 42134203, 81304927, 92291791, 81715085, 31458801, 
  77151104, 45948981, 47954253, 85936272, 21895914, 18493531, 83113543, 
  66914065, 90726268, 92143568, 7178239, 3730945, 45743734, 15774906, 
  88339755, 40235934, 76069572, 56906677, 96769907, 79972341, 54937093, 
  94318769, 77488424, 69324569, 3253125, 86028605, 44422108, 30412974, 
  59501492, 90364626, 63498837, 35336360, 1095986, 33329298, 58219969, 
  31530168, 63333296, 71871177, 69839107, 76576969, 91282757, 90842268, 
  18087031, 30617071, 32503858, 32853684, 90232724, 17920680, 21326264,
  78293505, 60913985, 95906805, 6202556, 68502252, 43658078, 7850022,
  63991013, 63512029, 36749905, 29205262, 44719222, 45834366, 57196040,
  98713930, 52819752, 47602535, 20573498, 21989358, 72213151, 76320606, 
  69160266, 80899407, 20543514, 2630004, 66070459, 78213131, 57551814, 
  27359763, 58601211, 96613521 

    */


public class PegionHoleAlgo
{
    public int sort_PegionHole(List<int> A)
    {
        int _min =A[0] , _max = 0;
        //1) find the min and max element from the array
        for(int i = 0; i < A.Count; i++)
        {
            if (_min > A[i])
            {
                _min = A[i];
            }

            if(_max < A[i])
            {
                _max = A[i];
            }
        }
        //            Console.WriteLine(_min);
        //            Console.WriteLine(_max);


        // 2) Find range for the pegionHole array using the formula : max-min-1

        int range = _max - _min + 1;
        // 3) Declare an array of length range

        int[] pegionHole = new int[range];

        // 4) Loop through the original array and copy the elements 

        for(int j = 0; j < A.Count; j++)
        {
            pegionHole[A[j] - _min] = A[j];

        }


        int index = 0;
        for(int i = 0; i < range; i++)
        {
            if (pegionHole[i] != 0)
            {
                A[index] = pegionHole[i];
                index++;
            }
        }

        int max_diff = 0;
        int[] maxDifferenceArray = new int[A.Count];

        for (int k = 0; k < A.Count-1; k++)
        {
            if(A[k+1] - A[k] > max_diff)
            {
                max_diff = A[k+1] - A[k];
            }


        }



        return max_diff;
    }

}
}
