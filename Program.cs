using System;
namespace ProvaT2
{
    //PRE: rep 3 números
    public class validate_num
    {
        public static bool InRange(int num, int min, int max)
        {
            return num >= min && num <= max;
        }

        public static bool MesLlarg(int mes)
        {
            return mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12;
        }

        public static bool Bisiesto(int any)
        {
            return (any % 400 == 0) || ((any % 4 == 0) && (any % 100 != 0));
        }

        public static void Main()
        {
            const string Msg1 = "Introdueix el dia, mes i any";
            const string Msg2 = "El dia no esta dins del rang";
            const string Msg3 = "El mes no esta dins del rang";
            const string Msg4 = "La data es correcta";
            const string FormatError = "El format de la dada es incorrecte";
            int dia, mes, any;
            bool validat = true;

            Console.WriteLine(Msg1);
            try
            {
                dia = int.Parse(Console.ReadLine());
                mes = int.Parse(Console.ReadLine());
                any = int.Parse(Console.ReadLine());
                if (InRange(mes, 1, 12))
                {
                    if (MesLlarg(mes) && !InRange(dia, 1, 31))
                    {
                        Console.WriteLine(Msg2);
                        validat = false;
                    }
                    else if (mes == 2 && !InRange(dia, 1, 28) && !Bisiesto(any))
                    {
                        Console.WriteLine(Msg2);
                        validat = false;
                    }
                    else if (mes == 2 && !InRange(dia, 1, 29) && Bisiesto(any))
                    {
                        Console.WriteLine(Msg2);
                        validat = false;
                    }
                    else if (!InRange(dia, 1, 30))
                    {
                        Console.WriteLine(Msg2);
                        validat = false;
                    }
                }
                else
                {
                    Console.WriteLine(Msg3);
                    validat = false;
                }
                if (validat)
                {
                    Console.WriteLine(Msg4);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(FormatError);
            }
        }
    }//POST: retorna si els números (dd, mm, yyyy) estan dins del rang de data corresponent
}