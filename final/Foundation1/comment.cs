class Comment
{
    public string Commenter { get; }
    public string Text { get; }

    public Comment(string commenter, string text)
    {
        Commenter = commenter;
        Text = text;
    }
}