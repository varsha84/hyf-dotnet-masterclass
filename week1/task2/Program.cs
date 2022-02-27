//2- String/Math
//Return the number (count) of vowels in the given string. Consider a, e, i, o, u as vowels.

string input = "Intellectualization";
int vowelCount = GetVowelCount(input); //TODO: Implement GetVowelCount 
int GetVowelCount(string input){
    string str = input.ToLower();
    int count = 0;
    foreach(char element in str){
        if(element == 'a'){
            count = count + 1;
        }
        else if(element == 'e'){
            count = count + 1;
        }
        else if(element == 'i')
        {
            count = count + 1;
        }
        else if(element == 'o'){
            count = count + 1;
        }
        else if(element == 'u'){
            count = count + 1;
        }
    }
    return count;
}
Console.WriteLine($"Number of vowels: {vowelCount}");
