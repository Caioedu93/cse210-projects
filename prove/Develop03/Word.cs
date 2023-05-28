public class Word
{
    private string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public void Show()
    {
        hidden = false;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public string GetText()
    {
        return text;
    }
}
