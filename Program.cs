using System;
using Prova;
namespace ProvaT2
{
    //Precon: L'usuari escriu quin numero vol buscar en l'array
    //Postcon: L'usuari sap si el numero esta en l'array o no
    public class Program
    {
        public static void Main()
        {
            const string Msg1 = "Write what number do you want to search in the array";
            const string Msg2 = "The number is not in the array";
            const string Msg3 = "The number is in the array";
            const string FormatError = "The format of the number is incorrect";
            int[] array = { 10, 4, 6, 4, 8, -13, 2, 3 };
            int key;
            Console.WriteLine(Msg1);
            try
            {
                key = int.Parse(Console.ReadLine());
                SecondSort.Order(ref array, 0, array.Length - 1);
                if(SearchClass.BinarySearch(array, 0, array.Length-1, key) == -1)
                {
                    Console.WriteLine(Msg2);
                }
                else
                {
                    Console.WriteLine(Msg3);
                }
                for(int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }catch (FormatException)
            {
                Console.WriteLine(FormatError);
            }
        }
    }
}