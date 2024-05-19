using System.Text.RegularExpressions;

namespace Utils
{
    public class InputUtils
    {
        public static uint ReadValidUInt()
        {
            uint result;
            while (true)
            {
                try
                {
                    result = Convert.ToUInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid unsigned integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too large. Please enter a valid unsigned integer.");
                }
            }
            return result;
        }

        public static int ReadValidInt()
        {
            int result;
            while (true)
            {
                try
                {
                    result = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid unsigned integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too large. Please enter a valid unsigned integer.");
                }
            }
            return result;
        }

        public static double ReadValidDouble()
        {
            double result;
            while (true)
            {
                try
                {
                    result = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too large. Please enter a valid number.");
                }
            }
            return result;
        }

        public static string ReadValidPhone()
        {
            while (true)
            {
                try
                {
                    string result = Console.ReadLine();
                    if (IsValidPhoneNumber(result))
                    {
                        return result;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid login. Please enter a login with a minimum length of 5 characters, using only Latin letters and digits.");
                }
            }
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\+380\d{9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        public static string ReadValidLogin()
        {
            while (true)
            {
                try
                {
                    string result = Console.ReadLine();
                    if (IsValidLogin(result))
                    {
                        return result;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid login. Please enter a login with a minimum length of 5 characters, using only Latin letters and digits.");
                }
            }
        }

        public static bool IsValidLogin(string login)
        {
            string pattern = @"^[a-z]{5,}[a-z0-9]*$";
            return Regex.IsMatch(login, pattern);
        }
    }
}

