using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var currName in usernames)
            {
                if (currName.Length > 3 && currName.Length <= 16)
                {
                    bool isUsernameValid = true;
                    foreach (var currChar in currName)
                    {

                        if (!(char.IsLetterOrDigit(currChar) || currChar == '_' || currChar == '-'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }
                    if (isUsernameValid)
                    {
                        Console.WriteLine(currName);
                    }

                }
            }
        }
    }
}
