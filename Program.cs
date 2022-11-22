

//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
string input_Value = Console.ReadLine();
int Value = Convert.ToInt32(input_Value);
int i = 2;
while (Value >= i)
{
    if (i % 2 == 0)
    {
        System.Console.Write(i + ", ");
        i++;
    }
    else
    {
        i++;
    }

}

