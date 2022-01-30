using System;

namespace Mod2HW1
{
    public class Starter
    {
        private static Actions actions = new Actions();

        public void Run()
        {
            int[] arr = GenerateArray();

            FindMetod(arr);
            actions.ExportToFile();
        }

        public int[] GenerateArray()
        {
            Random rnd = new Random();
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 4);
            }

            return arr;
        }

        private static void FindMetod(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    Result result1 = actions.FirstMetod();
                    if (result1.Status == false)
                    {
                        actions.LogError(result1.Message);
                    }
                }
                else if (arr[i] == 2)
                {
                    Result result2 = actions.SecondMetod();
                    if (result2.Status == false)
                    {
                        actions.LogError(result2.Message);
                    }
                }
                else if (arr[i] == 3)
                {
                    Result result3 = actions.ThirdMetod();
                    if (result3.Status == false)
                    {
                        actions.LogError(result3.Message);
                    }
                }
            }
        }
    }
}