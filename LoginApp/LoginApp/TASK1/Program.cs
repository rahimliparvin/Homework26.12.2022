using TASK1;
using TASK1.Errors;

#region Login


GetLogin();

static void GetLogin()
{
    Login login = new Login();

    Console.WriteLine("rolId daxil et :");
    int rolId = int.Parse(Console.ReadLine());
    Console.WriteLine("email daxil et :");
    string email = Console.ReadLine();
    Console.WriteLine("password daxil et :");
    string password = Console.ReadLine();


    if (email != "test@code.edu.az" && password != "test12345")
    {
        Console.WriteLine(Errors.WrongInfo);
        return;
    }
    if (rolId !=1)
    {
        Console.WriteLine(Errors.WrongRol);
    }

    if (rolId == 1 && email == "test@code.edu.az" && password == "test12345" )
    {
        Console.WriteLine(Errors.CorrectWord);
    }
}

#endregion


