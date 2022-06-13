



int firstNumber = Input("Введите первое число: ");
int secondNumber = Input("Введите второе число: ");

if(Square(firstNumber)==secondNumber || Square(secondNumber) == firstNumber)
{
    Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет"); 
}

int Square(int a)
{
    return a*a;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}