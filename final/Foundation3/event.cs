class Event
{
    public string name;
    public DateTime date;
    public Address address;

    public Event(string name, DateTime date, Address address)
    {
        this.name = name;
        this.date = date;
        this.address = address;
    }

    public string GetEventDetails()
    {
        return $"Event: {name}\nDate: {date}\nLocation: {address.GetAddress()}";
    }
}
