// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("введите числа, через пробел ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

void CountNumb(int[] tuArray)
{
    int count = 0;
    for (int i = 0; i < tuArray.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($" Чисел больше 0 = {count}");
}
CountNumb(array);