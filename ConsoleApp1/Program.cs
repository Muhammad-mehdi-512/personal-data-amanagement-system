using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

Dictionary<string, object> get_personal_data(string n, long t, string c,  string e, string num)
{
    var peronsal_data = new Dictionary<string, object>();

    peronsal_data.Add("Name", n);
    peronsal_data.Add("Age", t);
    peronsal_data.Add("City", c);
    peronsal_data.Add("Email", e);
    peronsal_data.Add("Phone Number", num);

    return peronsal_data;
}

string get_email(string? temp)
{
    while (string.IsNullOrEmpty(temp) || !temp.Contains('@'))
    {
        Console.Write("Invalid email, Please enter correct email: ");
        temp = Console.ReadLine()?.Trim();
    }
    return temp;
}
string get_phone_number(string? temp)
{
    while (string.IsNullOrWhiteSpace(temp) || !temp.All(char.IsDigit))
    {
        Console.Write($"Invalid Phone Number, Please enter corrrect Phone Number: ");
        temp = Console.ReadLine()?.Trim();
    }
    return temp;
}

string get_string_values(string? temp,  string value)
{
    while (string.IsNullOrWhiteSpace(temp) || !Regex.IsMatch(temp,  @"^[a-zA-Z]+(\s[a-zA-Z]+)*$"))
    {
        Console.Write($"Invalid {value}, Please enter corrrect {value}: ");
        temp = Console.ReadLine()?.Trim();
    }
    return temp;
}

short  get_int_values(string? temp, string value)
{
    short a;
    while (string.IsNullOrEmpty(temp) || !short.TryParse(temp, out a))
    {
        Console.Write($"Invalid {value}. Please enter corrrect {value}: ");
        temp = Console.ReadLine()?.Trim();
    }
    temp = null;
    return a;
}

void show_menu()
{
    Console.WriteLine("--------------");
    Console.WriteLine("| 1. Add Info   |");
    Console.WriteLine("| 2. View Info |");
    Console.WriteLine("| 3. Exit          |");
    Console.WriteLine("--------------");
}

short get_menu_option()
{
    Console.Write("Choose the numbers from 1 to 3 as u can see in the menu: ");
    string? temp = Console.ReadLine();
    short option = get_int_values(temp, value: "option");
    int[] valid_options = { 1, 2, 3 };

    while (true)
    {
        if (valid_options.Contains(option))
        {
            return option;
        }
        Console.Write($"You entered {option}. Please enter between 1 to 3: ");
        option = get_int_values(temp, value: "option");
    }
}

int main()
{
    show_menu();
    short option = get_menu_option();
    do
    {
        var personal_data = new Dictionary<string, object>();
        switch (option)
        {
            case 1:

                Console.Write("Enter your name: ");
                string? name = Console.ReadLine()?.Trim();
                name = get_string_values(name, value: "name");

                Console.Write("Enter your age: ");
                string? temp_age = Console.ReadLine()?.Trim();
                long age = get_int_values(temp_age, value: "age");

                Console.Write("Enter your city: ");
                string? city = Console.ReadLine()?.Trim();
                city = get_string_values(city, value: "city");

                Console.Write("Enter your email: ");
                string? email = Console.ReadLine()?.Trim();
                email = get_email(email);

                Console.Write("Enter your phone number: ");
                string? phone_number = Console.ReadLine()?.Trim();
                phone_number = get_phone_number(phone_number);

                personal_data = get_personal_data(name, age, city, email, phone_number);

                try
                {
                    using (StreamWriter writer = new StreamWriter("examples.txt", append: true))
                    {
                        writer.WriteLine("-------------------------------------");
                        foreach (var(key, value) in personal_data)                 
                        {                                                                                           
                            writer.WriteLine($"{key}: {value}");                             
                        }                                                                                           
                        writer.WriteLine("-------------------------------------");
                        writer.WriteLine();
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File: example.txt not found");
                    break;
                }

                break;

            case 2:
                try
                {
                    using (StreamReader reader = new StreamReader(@"D:\.NET\ConsoleApp1\ConsoleApp1\bin\Debug\net10.0\examples.txt"))
                    {
                        string? content = reader.ReadToEnd(); 
                        Console.WriteLine(content);
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File: example.txt not found");
                    break;
                }

                break;

            case 3:

                break;
        }
        option = get_menu_option();
    }
    while (option != 3);
    return 0;
}

main();