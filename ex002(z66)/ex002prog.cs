public class ex002prog
{
  public static int Input(string msg)
  {
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
  }

  public static int SummFromMToN(int numberFrom, int numberTo)
  {
    if (numberFrom >= numberTo) 
    return numberFrom + SummFromMToN(numberFrom - 1, numberTo);
    return 0;
  }
  public static void ex002()
  {
    int valueM = Input("Введите значение M: ");
    int valueN = Input("Введите значение N: ");
    if (valueM<valueN)
    {
    Console.Write($"Сумма натуральных элементов в промежутке от {valueM} до {valueN} = ");
    Console.Write(SummFromMToN(numberFrom:valueN, numberTo:valueM));
    }
    else Console.WriteLine("M должно быть меньше чем N! Попробуйте еще раз.");
  }
}