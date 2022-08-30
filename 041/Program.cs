// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел (M): ");
int mNumbers = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [mNumbers]; 
Console.Write("Введите числа (M): "); 

for (int i = 0; i < mNumbers; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}    
Console.WriteLine($"Числа пользователя: [{String.Join(": ", numbers)}]");

int count = 0;
for(int i = 0; i < mNumbers; i++)
{
    if(numbers[i] > 0) count++;
}
Console.WriteLine($"Кол-во чисел больше 0: {count}");


