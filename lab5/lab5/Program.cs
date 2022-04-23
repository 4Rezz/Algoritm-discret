using System;

namespace lab5
{
    class Program
    {

        static String[] Dfunct(String[] A, String[] B, String[] C)
        {
            String[] D = new String[A.Length * B.Length * C.Length];
            int j = 0;
            for (int ic = 0; ic < C.Length; ic++)
            {
                for (int ib = 0; ib < B.Length; ib++)
                {
                    for (int ia = 0; ia < A.Length; ia++)
                    {
                        D[j] = " " + C[ic] + " " + B[ib] + " " + A[ia];
                        j++;
                    }

                }
            }
            return D;
        }
        static int[] Bitrow(int[] A, int[] C)
        {
            int[] Bit = new int[C.Length];

            for (int i = 0; i < Bit.Length; i++)
                Bit[i] = 0;

            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < C.Length; j++)
                    if (C[j] == A[i])
                    {
                        Bit[j] = 1;
                        break;
                    }

            return Bit;
        }

        static int[] opNot(int[] A)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1)
                    D[i] = 0;
                else
                    D[i] = 1;

            return D;
        }
        static int[] opAnd(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1 && B[i] == 1)
                    D[i] = 1;
                else
                    D[i] = 0;

            return D;
        }
        static int[] opOr(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1 || B[i] == 1)
                    D[i] = 1;
                else
                    D[i] = 0;

            return D;
        }

        static int[] opDifference(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1 && B[i] == 0)
                    D[i] = 1;
                else
                    D[i] = 0;

            return D;
        }
        static int[] opXOR(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == B[i])
                    D[i] = 0;
                else
                    D[i] = 1;

            return D;
        }

        static void taskone()
        {
            String[] A = { "a", "b", "c" };
            String[] B = { "x", "y", "z" };
            String[] C = { "0", "1" };
            String[] D = Dfunct(A, B, C);

            Console.WriteLine("TASK1\nCxBxA:");
            Array.ForEach(D, Console.WriteLine);
            Console.WriteLine();
        }

        static void tasktwo()
        {
            int[] Cs = { 2, 3, 6, 7, 8, 9 };
            int[] As = { 2, 6, 7 };
            int[] Bs = { 3, 8 };

            int[] bA = Bitrow(As, Cs);
            int[] bB = Bitrow(Bs, Cs);
            Console.WriteLine("TASK2\n" +
                              "U:        " + string.Join(" ", Cs));
            Console.WriteLine("A:        " + string.Join(" ", bA));
            Console.WriteLine("B:        " + string.Join(" ", bB));
            Console.WriteLine("Not A:    " + string.Join(" ", opNot(bA)));
            Console.WriteLine("A And B:  " + string.Join(" ", opAnd(bA, bB)));
            Console.WriteLine("A Or B:   " + string.Join(" ", opOr(bA, bB)));
            Console.WriteLine("A Diff B: " + string.Join(" ", opDifference(bA, bB)));
            Console.WriteLine("A Xor B:  " + string.Join(" ", opXOR(bA, bB)));
        }
        static void Main(string[] args)
        {
            // Завдання 1
            taskone();
            // Завдання 2
            tasktwo();
        }
    }
}