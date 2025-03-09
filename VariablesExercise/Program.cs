namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string middleName = "Johnny";
            int weight = 203;
            char gender = 'm';
            bool likeBaseball = false;
            double averageTime = 35.6;
            decimal averageScore = 12.78m;
        
            Console.WriteLine($"Donald J BECKER is a baseball player.\n His middle name is: {middleName}\n " +
                              $"His gender is : {gender}\n Saying that he doesn't like baseball is obviously {likeBaseball}." +
                              $"\n He weight {weight} lbs.\n And his score is {averageScore} on average time {averageTime} seconds. ");
        }
    }
}
