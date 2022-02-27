//5. Arrays
//Given an integer array as an input, if the length of the array is not even write the warning message, otherwise split the array in half and add both resulting arrays together and write the result.

int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7, 9 };
int[][] splitArray = Split(input);
int[] result = AddArray(splitArray);

int[][] Split(int[] input){ 

    int len = input.Length/2;
    int [][] result = new int[2][];
    result[0] = new int[len];
    result[1] = new int[len];

    if(((input.Length)%2)!=0){
        Console.WriteLine($"array lenth is not even");
    }
    else{
       
        for(int i=0; i<len;i++){
            result[0][i] = input[i];
        }
        for(int i=0; i<len;i++)
        {
            result[1][i] = input[i+len];
        }     
    }
    return result;
}

int [] AddArray(int[][] splitArray){
    int len =splitArray[0].Length;
    int [] result = new int[len];
    for(int i=0; i<len;i++){
        result[i] = splitArray[0][i] + splitArray[1][i];
    }   
    return result;
}

void WriteResult(int[] result){
    Console.WriteLine(String.Join(",", result));
}

WriteResult(result);
