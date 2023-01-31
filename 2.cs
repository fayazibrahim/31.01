using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    
    
        
            int[] nums = { 29, 5, -96, -7, 25, 47 };

            int[] arr = musbeted(nums);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine(arr[i]);
                }
                
            }

            

        }

        
            static int[] musbeted(int[] nums)
        {
            int[] arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>0)
                {
                    arr[i] = nums[i];
                }
            }

            return arr;

            

        



    }
}
