using System.IO;
using System;

namespace lab6
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            FileS f = new FileS();
            int[,] result = f.ReadFile();

            iMx matrix = new iMx();
            sMx sumMatrix = new sMx();

            int[,] IncMatrix = matrix.createMatrix(f, result);
            int[,] sMatrix = sumMatrix.createMatrix(f, result);

            iMx.printMatrix(IncMatrix, f);
            Console.WriteLine();
            sMx.printMatrix(sMatrix, f);
            
            f.WriteIncident(IncMatrix);
            f.WriteSumizhn(sMatrix);
            
            //степінь вершини графу 7
            int[,] arcs = GCharacter.FindArc(sumMatrix, sumMatrix.createMatrix(f, result));

            Console.WriteLine();
            for (int i = 1; i < f.GetN() + 1; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{arcs[i, j]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            GCharacter.isIsolated(sumMatrix, arcs);
            
            Console.WriteLine();
            GCharacter.isHanging(sumMatrix, arcs);

            //Обхід вглиб 8
            Console.WriteLine();
            DFS dfs = new DFS();
            dfs.Search(sumMatrix, sumMatrix.createMatrix(f, result), 8); // з 8 починаю
            dfs.PrintResult();

            //Обхід вшир 9
            BFS bfs = new BFS();
            bfs.Search(sumMatrix, sumMatrix.createMatrix(f, result), 8); // тут також з 8
            bfs.PrintResult();
            // 10
            WeightMatrix wMx = new WeightMatrix();
            int[,] wMtx = f.ReadFileWeigh();
            int[,] WMat = wMx.createMatrix(f, wMtx);
            WeightMatrix.printMatrix(WMat, f);  
        }
    }
}

// 6,7,8,9,10