Console.WriteLine("Enter a string of characters below!");
string inputString = Console.ReadLine();
long sumOfRedNumbers = 0;
Console.WriteLine();

for (int i = 0; i < inputString.Length; i++)
{
    for (int j = i + 1; j < inputString.Length; j++)
    {
        char singleNumber = inputString[i];
        char lookingForAMatch = inputString[j];

        if (!Char.IsDigit(lookingForAMatch))
        {
            break;
        }
        if (singleNumber == lookingForAMatch)
        {
            PrintStartOfString(i);
            PrintRedNumbers(i, j);
            PrintEndOfString(j);
            sumOfRedNumbers += ConvertRedNumbersToInt(i, j);
            break;
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}

Console.WriteLine($"Summan av siffrorna är: {sumOfRedNumbers}");


void PrintStartOfString(int i)
{
    Console.ForegroundColor = ConsoleColor.Gray;
    string StartOfString = inputString.Substring(0, i);
    Console.Write(StartOfString);
}

void PrintRedNumbers(int i, int j)
{
    Console.ForegroundColor = ConsoleColor.Red;
    string RedNumbers = inputString.Substring(i, j - i + 1);
    Console.Write(RedNumbers);
}

void PrintEndOfString(int j)
{
    Console.ForegroundColor = ConsoleColor.Gray;
    string endOfString = inputString.Substring(j + 1);
    Console.WriteLine(endOfString);
}


long ConvertRedNumbersToInt(int i, int j)
{
    return Convert.ToInt64(inputString.Substring(i, j - i + 1));
}
