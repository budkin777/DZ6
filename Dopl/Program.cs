Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int [] binarySystem = new int [10];
binarySystem[0] = 1;
for (int i = 1; i < 10; i++)
{
    binarySystem[i] = binarySystem[i - 1] * 2;
}

int [] reversBinarySystem = new int [10];
for (int i = 0; i < 10; i++)
{
    reversBinarySystem[i] = binarySystem [9 - i];
}
Console.WriteLine($"[{String.Join(", ", reversBinarySystem )}]");

//Дальше не знаю) 
