using System;

public class Website
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public string IpAddress { get; set; }

    public Website() { }

    public Website(string name, string url, string description, string ipAddress)
    {
        Name = name;
        Url = url;
        Description = description;
        IpAddress = ipAddress;
    }

    public void InputData()
    {
        Console.Write("Name of site: ");
        Name = Console.ReadLine();

        Console.Write("URL: ");
        Url = Console.ReadLine();

        Console.Write("Description: ");
        Description = Console.ReadLine();

        Console.Write("IP-addres: ");
        IpAddress = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"Site: {Name}\nURL: {Url}\nDescription: {Description}\nIP: {IpAddress}";
    }
}
