namespace Assignment_5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "RADAR";
            int L = 0;
            int R = userInput.Length - 1;

            IsPalindrome(userInput, L, R);

            void IsPalindrome(string input, int L, int R)
            {

                if (L >= R)
                {
                    Console.WriteLine("The String is Palindrome");
                }
                else if (input[L].ToString().ToLower() != input[R].ToString().ToLower())
                {
                    Console.WriteLine("The String is not a Palindrome");
                }
                else
                {
                    IsPalindrome(input, L + 1, R - 1);
                    
                }


            }




        }
       
       
    }
}
