
int Max(int[] array)
{
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > result)
        {
            result = array[i];
        }
    }
    return result;
}

int[] array = {51,22,43,64,75,16,79,88,29,100};

Console.WriteLine(Max(array));