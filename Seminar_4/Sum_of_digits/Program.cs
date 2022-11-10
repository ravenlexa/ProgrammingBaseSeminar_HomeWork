/*Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе. Для решения задания использование цикла for является обязательным условием*/
int SumofDigits(int number)
{
    string strNumber = Math.Abs(number).ToString();
    int sum = 0;
    for (int i = 0; i < strNumber.Length; i++)
    {
        sum = sum + int.Parse(Convert.ToString(strNumber[i])); //Вот это подсмотрел. Писал просто sum = sum + strNumber[i] и ничего не получалось.
    }
   
    return sum;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumofDigits(number);
Console.WriteLine(sum);
