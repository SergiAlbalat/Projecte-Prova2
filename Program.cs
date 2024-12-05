using System;
namespace ProvaT2
{
    //Precon: L'usuari introdueix 20 valors
    //Postcon: L'usuari rep els valors ordenats i pot buscar un valor especific
    public class Program
    {
        public static void Swap(ref int firstNum, ref int secondNum)
        {
            int aux = firstNum;
            firstNum = secondNum;
            secondNum = aux;
        }
        public static int[] BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
            return array;
        }
        public static void WriteArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
        }
        public static bool BinarySearch(int[] arr, int first, int last, int key)
        {
            if (last >= first)
            {
                int mid = first + (last - first) / 2;
                if (arr[mid] == key)
                {
                    return true;
                }
                if (arr[mid] > key)
                {
                    return BinarySearch(arr, first, mid - 1, key);
                }
                else
                {
                    return BinarySearch(arr, mid + 1, last, key);
                }
            }
            return false;
        }
        public static void Main()
        {
            const string Msg1 = "Write 20 values and i will store them";
            const string Msg2 = "What number do you want to find?";
            const string Msg3 = "It is";
            const string Msg4 = "It's not";
            const string Msg5 = "Your numbers: ";
            const string FormatError = "The format of the number is incorrect";
            int[] array = new int[20];
            int key;
            Console.WriteLine(Msg1);
            try
            {
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                array = BubbleSort(array);
                Console.Write(Msg5);
                WriteArray(array);
                Console.WriteLine(Msg2);
                key = int.Parse(Console.ReadLine());
                Console.WriteLine(BinarySearch(array, 0, array.Length-1, key) ? Msg3 : Msg4);

            }catch (FormatException)
            {
                Console.WriteLine(FormatError);
            }
        }
    }
}