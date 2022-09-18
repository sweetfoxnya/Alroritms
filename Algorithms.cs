using System;

public class Algorithms
{
	public Algorithms()
	{
        public static int Alrorithms_1(int a, int b) 
        {
            return a + b 
        }

        public static int Alrorithms_2(int[] array)
        {
            
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
	 static double Algoritm_4_1(int[] koff, int kol_koff)
	    {
		double pol = 0;
		double x = 1.5;
		int kol = 0;

		for (int i = 0; i < kol_koff; i++)
		{
		    pol += koff[i] * Math.Pow(x, kol);
		    kol += 1;

		}
		return (pol);
	    }
        public static double Algoritm_4_2(int[] koff, int kol_koff)
    {
        double pol = 0;
        double x = 1.5;

        for (int i = kol_koff - 1; i >= 0; i--)
        {
            pol *= x;
            pol += koff[i];

        }
        return (pol);
    }

        public static int[] oddEvenSort(int[] arr, int n)

        {
            bool isSorted = false;

            while (!isSorted)

            {

                isSorted = true;

                int temp = 0;

                for (int i = 1; i <= n - 2; i += 2)

                { 

                    if (arr[i] > arr[i + 1])

                    {

                        temp = arr[i];

                        arr[i] = arr[i + 1];

                        arr[i + 1] = temp;

                        isSorted = false;

                    }

                }


                for (int i = 0; i <= n - 2; i += 2)

                {

                    if (arr[i] > arr[i + 1])

                    {

                        temp = arr[i];

                        arr[i] = arr[i + 1];

                        arr[i + 1] = temp;

                        isSorted = false;

                    }

                }

            }

            return int[] arr;

        }
    }
}



