namespace EntendendoAlgoritmos.Classes;
public class Recursao
{
    public static int Fatorial(int number)
    {
        return number switch
        {
            1 => 1,
            _ => number * Fatorial(number - 1),
        };
    }
}
