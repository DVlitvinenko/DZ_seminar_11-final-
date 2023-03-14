public class ex003prog
{
  public static int Input(string msg)
  {
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
  }

  public static int FunctionAkkerman(int valueM, int valueN, int result = 0)
  {
    if (valueM ==0)
    {
      result += valueN+1;
    }
    if (valueM>0 & valueN == 0)
    {
      result += FunctionAkkerman(valueM-1,1);
    }
    if (valueM>0 & valueN > 0)
    {
      result += FunctionAkkerman(valueM-1,FunctionAkkerman(valueM, valueN-1));
    }
    return result;
  }
  public static void ex003()
  {
    int valueM = Input("Введите значение M: ");
    int valueN = Input("Введите значение N: ");
    if (valueM<0&valueN<0)
    Console.WriteLine("Введеные значения отрицательны! Введите положительные значения.");
    else Console.WriteLine(FunctionAkkerman(valueM,valueN));
  }
}