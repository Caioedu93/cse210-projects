class Concert : Event
{
    private string artist;

    public Concert(string name, DateTime date, Address address, string artist)
        : base(name, date, address)
    {
        this.artist = artist;
    }

    public string GetArtistMessage()
    {
        return $"Don't miss the concert by {artist} at {name} on {date}!";
    }
}