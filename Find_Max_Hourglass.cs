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
            List<int> sums = new List<int>();

            int sum = 0;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    sum = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] + arr[i][j] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    sums.Add(sum);
                }
            }

            return sums.Max();
        }
        
        
