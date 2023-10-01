using System;

class Program
{
    public static void Main()
    {
        User user = new User();
        char choice;
        do
        {
            choice = user.UserChoice();

            switch (choice)
            {
                case '1': user.UserCreation(); break;
                case '2': user.UserDel(); break;
                case '3': user.UserInfo(); break;
                case '4': user.UserModification(); break;
                case '5': user.UserChanger(); break;
                case '6': user.UserExiting(); break;
                default: Console.WriteLine("\nInvalid choice input."); break;
            }
        } while (choice != '6');
    }
}