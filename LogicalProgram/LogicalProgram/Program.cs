using LogicalProgram;

Console.WriteLine("Welcome to Logical Programs");
Console.WriteLine("Enter 1 for Fibonacci Series");
Console.WriteLine("Enter 2 for Perfect Numbers");


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

}