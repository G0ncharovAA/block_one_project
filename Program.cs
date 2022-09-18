Console.WriteLine("Введите размер массива, n:");
int n = Convert.ToInt32(Console.ReadLine());

int inputIndex = 0;
int outputIndex = -1;
string[] inputArray = new string[n];
string[] outputArray = new string[n];

while (inputIndex < n)
{
    Console.WriteLine($"Введите элемента массива под индексом {inputIndex}");
    inputArray[inputIndex] = Console.ReadLine();
    if (inputArray[inputIndex].Length <= 3)
    {
        outputIndex++;
        outputArray[outputIndex] = inputArray[inputIndex];
    }
    inputIndex++;
}

int outputSize = outputIndex + 1;

if (outputSize > 0)
{
    outputIndex = 0;
    Console.WriteLine("Элементы результирующего массива:");
    while (outputIndex < outputSize)
    {
        Console.WriteLine(outputArray[outputIndex]);
        outputIndex++;
    }
}
else
{
    Console.WriteLine("Пустое множество");
}