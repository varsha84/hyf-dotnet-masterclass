// 1- String manipulation
// Complete the solution so that it reverses the string passed into it.
string input = "world";
string reversed = ReverseString(input); //TODO: Implement ReverseString

string ReverseString(string input)
{
    char[] characters = input.ToCharArray();
    Array.Reverse(characters);
    string  ReverseStr = new string(characters);
    return ReverseStr;

}

Console.WriteLine($"Reversed input value: {reversed}");