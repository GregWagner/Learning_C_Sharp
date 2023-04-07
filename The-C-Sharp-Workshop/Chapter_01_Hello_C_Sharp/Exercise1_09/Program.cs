

static bool IsPrime(int number) {
    if (number == 0 || number == 1) {
        return false;
    }
    int counter = 2;
    while (counter < Math.Sqrt(number)) {
        if (number % counter == 0) {
            return false;
        }
        ++counter;
    }
    return true;
}

Console.WriteLine("Enter a number to check whether it is prime:");
var input = int.Parse((Console.ReadLine()));
Console.WriteLine($"{input} is prime? {IsPrime(input)}");