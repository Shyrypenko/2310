using System;

public class Store
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ProfileDescription { get; set; }
    public string ContactPhone { get; set; }
    public string Email { get; set; }

    public Store() { }

    public Store(string name, string address, string profileDescription, string contactPhone, string email)
    {
        Name = name;
        Address = address;
        ProfileDescription = profileDescription;
        ContactPhone = contactPhone;
        Email = email;
    }

    public void InputData()
    {
        Console.Write("Name: ");
        Name = Console.ReadLine();

        Console.Write("Addres: ");
        Address = Console.ReadLine();

        Console.Write("Description: ");
        ProfileDescription = Console.ReadLine();

        Console.Write("Phone: ");
        ContactPhone = Console.ReadLine();

        Console.Write("Email: ");
        Email = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"Магазин: {Name}\nАдрес: {Address}\nОписание: {ProfileDescription}\nТелефон: {ContactPhone}\nEmail: {Email}";
    }
}