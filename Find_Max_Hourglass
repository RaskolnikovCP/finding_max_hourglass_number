        /*
        Given a 6x6 array, I define an hourglass in array to be a subset of values with indices falling in this pattern in array's graphical representation: 
        a b c
          d   
        e f g
        There are 16 hourglasses in array, and an hourglass sum is the sum of an hourglass' values. 
        The task is calculating the hourglass sum for every hourglass in array, then printing the maximum hourglass sum.
        */
        
        public int Find_Max_Matris_Part_HourGlasses(int[][] arr)
        {
            //int[][] arr = new int[6][];

            //int[] result = new int[16];

            int sum = 0;

            int max = 0;
           
            /*
            for (int i = 0; i < 6; i++)
            {
                //arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

                //Console.WriteLine(" result is: {0} ", arr[i][i]);
            }*/

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    //Console.WriteLine(" " + arr[i][j] + " "); 
                    sum = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] + arr[i][j] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    if (sum > max)
                    {
                        max = sum;
                    }
                }
            }

            return max;
        }
        
        
