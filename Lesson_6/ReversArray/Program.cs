//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]


int[] CreateNewArray(int size, int minV, int maxV)
{
    int[] arrayNew = new int[size];
    for (int i = 0; i < size; i++) arrayNew[i] = new Random().Next(minV, maxV + 1);
    return arrayNew;
}

void PrintArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i++)
    {
        Console.Write(printArray[i]);
        if (i != printArray.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
    Console.WriteLine();
}

int[] ReversArray(int[] arrayRevers)
{
    int k = arrayRevers.Length;
    for (int i = 0; i < k / 2; i++)
    {
        int temp = arrayRevers[i];
        arrayRevers[i] = arrayRevers[k - 1 - i];
        arrayRevers[k - 1 - i] = temp;
    }
    return arrayRevers;
}

int size_array = 7;
int min_V = -9;
int max_V = 9;

int[] createdArray = CreateNewArray(size_array, min_V, max_V);
PrintArray(createdArray);
int[] reversArray = ReversArray(createdArray);
PrintArray(reversArray);



