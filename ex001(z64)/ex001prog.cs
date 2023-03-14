public class ex001prog
{

  public static int Input(string msg)
  {
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
  }
  public static string NToOne(int N, string result = "")
  {
    if (N > 1)
      result += $"{N}, {NToOne(N - 1, result)}";
    else result += $"{N}";
    return result;
  }

  public static void ex001()
  {
    int numberN = Input("Введите число N: ");
    Console.WriteLine(NToOne(numberN));
  }
}