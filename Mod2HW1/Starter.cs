using System;
using System.IO;

namespace Mod2HW1
{
    public class Starter
    {
        private static Actions actions = new Actions();
        public void Run()
        {
            int[] arr = GenerateArray();
            Console.WriteLine();
            FindMetod(arr);
            ExportToFile();
        }

        public int[] GenerateArray()
        {
            Random rnd = new Random();
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 4);
                Console.Write(arr[i] + " ");
            }

            return arr;
        }

        private static void FindMetod(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Result result = null;
                if (arr[i] == 1)
                {
                    result = actions.FirstMetod();
                }
                else if (arr[i] == 2)
                {
                    result = actions.SecondMetod();
                }
                else if (arr[i] == 3)
                {
                    result = actions.ThirdMetod();
                }

                if (!result.Status)
                {
                    Logger.MyInstance.LogError(result.Message);
                }
            }
        }

        private void ExportToFile()
        {
            File.WriteAllText("log.txt", Logger.MyInstance.LogData);
        }
    }
}