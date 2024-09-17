
//4. Classical task
//Create function Fibonacci that returns N'th element of Fibonacci sequence (classic programming task).

int n = 6;
int nthNumber = Fibonacci(n); //TODO: Implement Fibonacci

int Fibonacci(int n)
{
    int n1 = 0, n2 = 1, next = 0;
    for (int i = 1; i < n; i++)
    {
        next = n1 + n2;
        n1 = n2;
        n2 = next;
    }
    return next;
}
Console.WriteLine($"Nth fibonacci number is {nthNumber}");