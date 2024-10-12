namespace OsnovyLab1;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Choose mode:\n" +
                          "1. Input 7 num and return min and max\n" +
                          "2. Input A, B and return massive AxB.\n" +
                          "3. Input num and return factorial num.\n" +
                          "4. Input X and return dividents.\n" +
                          "5. Input X, and return all num from 0 to X which end's 5\n\n" +
                          "Your choice: ");
        
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int[] inputNum = new int[7];
                    
                    Console.WriteLine("Input 7 numbers(Tap Enter after each num):");
                    
                    for (int i = 0; i < 7; i++)
                    {
                        inputNum[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int max = _max(inputNum);
                    
                    int min = _min(inputNum);

                    Console.Write("Your num: [");
                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(i == 6 ? $"{inputNum[i]}": $"{inputNum[i]}, ");
                    }
                    Console.Write($"], Max: {max}, Min: {min}");
                    Console.WriteLine("\n------------------------------------\n");
                    break;
                case 2:
                    Console.Write("Input X: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    
                    Console.Write("Input Y: ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    char[,] matrix = _makeMatrix(x, y);

                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            Console.Write(matrix[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n------------------------------------\n");
                    break;
                case 3:
                    Console.Write("Input X: ");
                    int userNumFactorial = Convert.ToInt32(Console.ReadLine());
                    
                    int factorial = _factorial(userNumFactorial);
                    
                    Console.WriteLine($"Factorial {userNumFactorial} = {factorial}");
                    Console.WriteLine("------------------------------------\n");
                    break;
                case 4:
                    Console.Write("Input X: ");
                    int userNumToDivide = Convert.ToInt32(Console.ReadLine());
                    
                    _findDivident(userNumToDivide);
                    
                    break;
                case 5:
                    Console.Write("Input X: ");
                    int limitByUserNum = Convert.ToInt32(Console.ReadLine());
                    
                    _numberEndsFive(limitByUserNum);
                    
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    Console.WriteLine("------------------------------------\n");
                    break;
            }
        }
    }

    private static int _max(int[] numbers)
    {
        int currentMax = int.MinValue;
        for (int i = 0; i < 7; i++)
        {
            int currentNumber = numbers[i];

            if (currentNumber > currentMax)
            {
                currentMax = currentNumber;
            }
        }
        
        return currentMax;
    }

    private static int _min(int[] numbers)
    {
        int currentMin = int.MaxValue;

        for (int i = 0; i < 7; i++)
        {
            int currentNumber = numbers[i];

            if (currentNumber < currentMin)
            {
                currentMin = currentNumber;
            }
        }
        
        return currentMin;
    }

    private static char[,] _makeMatrix(int rows, int cols)
    {
        char[,] matrix = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = 'x';
            }
        }
        
        return matrix;
    }

    private static int _factorial(int number)
    {
        int startFactorial = number;

        for (int i = number-1; i > 0; i--)
        {
            startFactorial *= i;
        }
        
        return startFactorial;
    }

    private static void _findDivident(int number)
    {
        Console.Write($"All divident {number}, it's: ");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine("\n------------------------------------\n");
    }

    private static void _numberEndsFive(int number)
    {
        if (number < 5)
        {
            Console.Write($"Your number {number} small than 5.");
            Console.WriteLine("\n------------------------------------\n");
            return;
        }

        Console.Write($"All num ends five from 0 to {number}, it's: ");
        for (int j = 0; j <= number; j++)
        {
            if (j % 5 == 0 && j % 10 != 0)
            {
                Console.Write($"{j} ");
            }
        }
        Console.WriteLine("\n------------------------------------\n");
    }
}
