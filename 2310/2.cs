using System;

public class Journal
{
    public string Name { get; set; }
    public int YearOfProduction { get; set; }
    public string Description { get; set; }
    public string ContactPhone { get; set; }
    public string Email { get; set; }

    public Journal() { }

    public Journal(string name, int yearOfProduction, string description, string contactPhone, string Email)
    {
        Name = name;
        YearOfProduction = yearOfProduction;
        Description = description;
        ContactPhone = contactPhone;
        Email = Email;
    }

    public void InputData()
    {
        Console.Write("Name: ");
        Name = Console.ReadLine();

        Console.Write("Year of production: ");
        YearOfProduction = int.Parse(Console.ReadLine());

        Console.Write("Description: ");
        Description = Console.ReadLine();

        Console.Write("Phone: ");
        ContactPhone = Console.ReadLine();

        Console.Write("Email: ");
        Email = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"Name: {Name}\nYear of production: {YearOfProduction}\nDescription: {Description}\nPhone: {ContactPhone}\nEmail: {Email}";
    }
}