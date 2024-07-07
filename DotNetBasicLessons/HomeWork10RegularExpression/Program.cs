using System.Text.RegularExpressions;

try
{
    Console.WriteLine("Enter your home phone number:");
    var homePhonenNumber = Console.ReadLine() ?? "";
    string patternHomePhonenNumber = @"^\d{7}$";
    Regex regexHomePhonenNumber = new Regex(patternHomePhonenNumber);
    bool isValidHomePhonenNumber = regexHomePhonenNumber.IsMatch(homePhonenNumber);

    if (isValidHomePhonenNumber)
    {
        Console.WriteLine("Your home phone number is correct!\n");
    }
    else
    {
        Console.WriteLine("Your home phone number is incorrect!\n");
    }


    Console.WriteLine("Enter your mobile phone number:");
    var MobilePhoneNumber = Console.ReadLine() ?? "";
    string patternMobilePhoneNumber = @"^\+?\d{12}$";
    Regex regexMobilePhoneNumber = new Regex(patternMobilePhoneNumber);
    bool isValidMobilePhoneNumber = regexMobilePhoneNumber.IsMatch(MobilePhoneNumber);

    if (isValidMobilePhoneNumber)
    {
        Console.WriteLine("Your mobile phone number is correct!\n");
    }
    else
    {
        Console.WriteLine("Your mobile phone number is incorrect!\n");
    }

    Console.WriteLine("Enter your email:");
    var email = Console.ReadLine() ?? "";
    string patternemail = @"^[a-zA-Z0-9._%+-]{1,40}@[a-zA-Z0-9.-]+\.(com|org|net|edu|gov)$";
    Regex regexemail = new Regex(patternemail);
    bool isValidemail = regexemail.IsMatch(email);

    if (isValidemail)
    {
        Console.WriteLine("Your email is correct!\n");
    }
    else
    {
        Console.WriteLine("Your email is incorrect!\n");
    }


    Console.WriteLine("Enter your full name:");
    var fullName = Console.ReadLine() ?? "";
    string patternfullName = @"^([A-Za-zА-Яа-яІіЇїЄє]{2,20}\s){2}[A-Za-zА-Яа-яІіЇїЄє]{2,20}$";
    Regex regexfullName = new Regex(patternfullName);
    bool isValidfullName = regexfullName.IsMatch(fullName);

    if (isValidfullName)
    {
        Console.WriteLine("Your full name is correct!\n");
    }
    else
    {
        Console.WriteLine("Your full name is incorrect!\n");
    }


    Console.WriteLine("Enter your password! The password must contain: one uppercase letter, one lowercase letter, one digit, one symbol, password length - from 8 to 16 characters!");
    var password = Console.ReadLine() ?? "";
    string patternpassword = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,16}$";
    Regex regexpassword = new Regex(patternpassword);
    bool isValidpassword = regexpassword.IsMatch(password);

    if (isValidpassword)
    {
        Console.WriteLine("Your password is correct!\n");
    }
    else
    {
        Console.WriteLine("Your password is incorrect!\n");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Incorrect data format.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error has occurred.");
    Console.WriteLine(ex.Message);
}

