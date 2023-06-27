//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11

int CountOfBinar(int user_num)
{
    int countOfDigit = 0;
    while (user_num!=0)
    {
    user_num = user_num / 2;
        countOfDigit++;
}
return countOfDigit;
}

int[] ConversionToBinar(int numToConvert)
{
    int n = CountOfBinar(numToConvert);
    int[] binarNum = new int[n];

    for (int i = n - 1; i >= 0; i--)
    {
        binarNum[i] = numToConvert % 2;
        numToConvert /= 2;
    }
    return binarNum;
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

int userNumber = 45;
int counElem = CountOfBinar(userNumber);
int[] binar = ConversionToBinar(userNumber);
PrintArray(binar);




