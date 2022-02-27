//3. Math/Array
//Given an array of the numbers return an array with two elements where first element represents sum of all negative numbers and second element represents multiplication of all positive numbers;
int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59,  -1852, 41, 5 };
int[] result = GetResult(arr); //TODO: Implement GetResult

int[] GetResult(int[] arr){
    int[] ResultArr = new int[2]; 
    int addNegNum = 0;
    int mulPosNum = 1;
        foreach(int number in arr){
            if(number <= 0){ 
                addNegNum = addNegNum + number;
                
            }
            else{
                mulPosNum = mulPosNum * number;
                
            }
    }
    ResultArr[0] = addNegNum;
    ResultArr[1] = mulPosNum;
    return ResultArr;
}
Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");