namespace TrouverNEntiersUniques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter a number:");
            string numberEnteredByUserAsString = Console.ReadLine();
            string resultString="[";
            int numberEnteredByUser = Convert.ToInt16(numberEnteredByUserAsString);
            int limitForLoop = numberEnteredByUser / 2;
            int[] arrayTheNumbers = new int[numberEnteredByUser];
            

            for (int i = numberEnteredByUser-1; i > limitForLoop; i--) 
            {
                arrayTheNumbers[i] = -i-1;
            }
            for (int i = 0; i < limitForLoop; i++)
            {
                arrayTheNumbers[i] = -arrayTheNumbers[limitForLoop+(i+1)];
            }
            if (numberEnteredByUser / 2 != 0)
            {
                arrayTheNumbers[limitForLoop] = arrayTheNumbers[0]-1;
                arrayTheNumbers[0] = 1;
            }

            for (int i = 0; i < numberEnteredByUser; i++)
            {
                resultString = resultString +Convert.ToString(arrayTheNumbers[i]) +",";
            }
            Console.WriteLine(resultString.Remove(resultString.Length-1, 1)+"]");
        }
    }
}
