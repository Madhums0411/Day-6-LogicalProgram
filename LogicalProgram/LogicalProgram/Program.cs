using LogicalProgram;

Console.WriteLine("Welcome to Logical Programs");
Console.WriteLine("Enter 1 for Fibonacci Series");
Console.WriteLine("Enter 2 for Perfect Numbers");
Console.WriteLine("Enter 3 for Prime numbers");
Console.WriteLine("Enter 4 for Reverse number");
Console.WriteLine("Enter 5 for Coupon Number");
Console.WriteLine("Enter 6 for Stop Watch");


int Problem = Convert.ToInt32(Console.ReadLine());


switch(Problem)
{

    case 1:
        FibonacciSeriesProblem fibonacciSeriesProblem = new FibonacciSeriesProblem();
        fibonacciSeriesProblem.FibonacciSeries();
        break;

    case 2:
        PerfectNumberProblem perfectNumberProblem = new PerfectNumberProblem();
        perfectNumberProblem.PerfectNumber();
        break;

    case 3:
        PrimeNumberProblem primeNumberProblem = new PrimeNumberProblem();
        primeNumberProblem.PrimeNumber();
        break;

    case 4:
        ReverseNumberProblem reverseNumberProblem = new ReverseNumberProblem();
        reverseNumberProblem.ReverseNumber();
        break;
    case 5:
        Console.Write("How many numbers you wants to generate: ");
        int N = Convert.ToInt32(Console.ReadLine());
        CouponNumbersProblem.CouponNumber(N);
        break;
    case 6:
        StopWatchProblem stopWatchProblem = new StopWatchProblem();
        stopWatchProblem.StopWatch();
        break;
}