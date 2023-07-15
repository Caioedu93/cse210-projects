class Conference : Event
{
    private string speaker;

    public Conference(string name, DateTime date, Address address, string speaker)
        : base(name, date, address)
    {
        this.speaker = speaker;
    }

    public string GetSpeakerMessage()
    {
        return $"Join us at {name} on {date} to hear {speaker} speak!";
    }
}