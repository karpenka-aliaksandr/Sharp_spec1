//Дан двумерный массив.

//7 3 2
//4 9 6
//1 8 5

//Отсортировать данные в нем по возрастанию.

//1 2 3
//4 5 6
//7 8 9

//Вывести результат на печать.


class Program

{

    public static void Main(string[] args)

    {

        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        PrintTwoDimensionalArray(a);
        a = Sort(a);
        Console.WriteLine();
        PrintTwoDimensionalArray(a);

    }

    static int[,] Sort(int[,] array)
    {
        int[] arrayForSort = ConvertTwoDimensionalArrayToOneDimensionalArray(array);
        Array.Sort(arrayForSort);
        return ConvertOneDimensionalArrayToTwoDimensionalArray(arrayForSort, array.GetLength(0), array.GetLength(1));

    }

    static int[] ConvertTwoDimensionalArrayToOneDimensionalArray(int[,] twoDimensionalArray)
    {
        int[] oneDimensionalArray = new int[twoDimensionalArray.GetLength(0) * twoDimensionalArray.GetLength(0)];
        int pos = 0;
        for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                oneDimensionalArray[pos++] = twoDimensionalArray[i, j];
            }
        }
        return oneDimensionalArray;
    }

    static int[,] ConvertOneDimensionalArrayToTwoDimensionalArray(int[] oneDimensionalArray, int dimension1, int dimension2)
    {
        int[,] twoDimensionalArray = new int[dimension1, dimension2]; 
        int pos = 0;
        for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                twoDimensionalArray[i, j] = oneDimensionalArray[pos++] ;
            }
        }
        return twoDimensionalArray;
    }

    static void PrintTwoDimensionalArray(int[,] twoDimensionalArray)
    {
        for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                Console.Write($"{twoDimensionalArray[i, j]}  ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

