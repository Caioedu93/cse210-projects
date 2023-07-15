using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Cityville", "Stateville", "12345");
        Address address2 = new Address("456 Oak Ave", "Townville", "Stateville", "67890");

        Concert concert = new Concert("Summer Concert", new DateTime(2023, 7, 15), address1, "John Smith");
        Conference conference = new Conference("Tech Conference", new DateTime(2023, 8, 10), address2, "Jane Doe");

        Console.WriteLine(concert.GetEventDetails());
        Console.WriteLine(concert.GetArtistMessage());
        Console.WriteLine();

        Console.WriteLine(conference.GetEventDetails());
        Console.WriteLine(conference.GetSpeakerMessage());
    }
}
