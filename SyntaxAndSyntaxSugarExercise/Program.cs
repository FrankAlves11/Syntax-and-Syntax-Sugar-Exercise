namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 12; 

            var response = answer < 23
                ? $"{answer} is less than nine"   : $"{answer} is greater than or equal to 23"; 

            Console.WriteLine(response);

        }
    }
}
