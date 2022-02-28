//5. Arrays
//Given an integer array as an input, if the length of the array is not even write the warning message, otherwise split the array in half and add both resulting arrays together and write the result.

int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7, 9 };

int halfLenth = 0;
if (input.Length % 2 == 0 | input != null)
{
    halfLenth = input.Length / 2;
    int[][] splitArray = Split(input);
    int[] result = AddArray(splitArray);
    WriteResult(result);

}
else
{
    Console.WriteLine($"array lenth is not even");

}

int[][] Split(int[] input)
{
    // create array with first half of orinal arrray //ConstrainedCopy (Array sourceArr, int sourceIndex, Array destinationArr, int destinationIndex, int length);

    int[] first = new int[halfLenth];
    Array.ConstrainedCopy(input, 0, first, 0, halfLenth);

    //create second array with the second half of original array
    int[] second = new int[halfLenth];
    Array.ConstrainedCopy(input, halfLenth, second, 0, halfLenth);

    // create the 2 dimentional array to be returned
    int[][] arr = new int[][] { first, second };

    return arr;
}

int[] AddArray(int[][] splitArray)
{
    //we crete new array and store the result of the of the two arrays in the newly created result array
    int[] result = new int[halfLenth];
    for (int i = 0; i < halfLenth; i++)
    {
        result[i] = splitArray[0][i] + splitArray[1][i];
    }
    return result;
}

void WriteResult(int[] result)
{
    Console.WriteLine(String.Join(",", result));
}


