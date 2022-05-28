// See https://aka.ms/new-console-template for more information
using RegexDay19;

Console.WriteLine("Hello, World!");


Console.WriteLine("Welcome to REGEX PROGRAM!\n");
Console.WriteLine("ENTER \n1 FOR VALIDATE FIRSTNAME REGEX PROGRAM \n2 FOR VALIDATE LASTNAME REGEX PROGRAM\n3 FOR VALIDATE EMAIL REGEX PROGRAM\n4 FOR VALIDATE MOBILE REGEX PROGRAM \n5 FOR VALIDATE PASSWORD MINIMUM 8 CHARACTERS REGEX PROGRAM\n6 FOR VALIDATE PASSWORD ATLEAST 1 UPPERCASE CHARACTERS REGEX PROGRAM\n7 FOR VALIDATE PASSWORD ATLEAST 1 NUMERIC CHARACTERS REGEX PROGRAM\n8 FOR VALIDATE PASSWORD ATLEAST 1 SPECIAL CHARACTERS REGEX PROGRAM\n9 FOR VALIDATE EMAIL SAMPLE REGEX PROGRAM\n");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        ValidFirstName nameObj = new ValidFirstName();
        if (nameObj.Validate_Name("Rupali"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 2:
        ValidFirstName lastNameObj = new ValidFirstName();
        if (lastNameObj.Validate_Name("Natewad"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 3:
        ValidateEmail EmailObj = new ValidateEmail();
        if (EmailObj.Validate_Email("abc.xyz@bl.co.in"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 4:
        ValidateMobile MobileObj = new ValidateMobile();    
        if(MobileObj.Validate_Mobile("91 7777755588"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 5:
        
        Password8Char.PasswordminObj = new Password8Char();
        if(PasswordminObj.Passwordmin("%Rupali4u344&"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 6:
        PasswordOneUC.UpperCase = new PasswordOneUC();
        if(UpperCaseObj.UpperCase("Rupali1234"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 7:
        PasswordMin1Num PwdMin1NumObj = new PasswordMin1Num();
        if (PwdMin1NumObj.Min1NumPwd("rupali1234"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;


    case 8:
        PWDSpecialChar.SpecialCharPwdobj = new PWDSpecialChar();
        if (SpecialCharPwdobj.SpecialCharPwd("rupalinate@"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 9:
        ValidateEmail  EmailSamplesObj = new ValidateEmail();
        string[] EmailArray = new string[]
        {
          "abc@yahoo.com",
          "abc-100@yahoo.com",
          "abc.100@yahoo.com",
          "abc111@abc.com",
          "abc-100@abc.net",
          "abc.100@abc.com.au",
          "abc@1.com",
          "abc@gmail.com.com",
          "abc+100@gmail.com"
        };

        foreach(string i in EmailArray)
        {

        if (EmailSamplesObj.Validate_Email(i))
        {
            Console.WriteLine(i+" is Valid");
        }
        else
        {
            Console.WriteLine(i+" is Invalid");
        }

        }
        break;

}