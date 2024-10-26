using System;

class Words
{
    public string Text { get; private set; }
    public bool HiddenWords { get; private set; }

    public Words(string text, bool hiddenWords = false)
    {
        Text = text;
        HiddenWords = hiddenWords;
    }

    public void Hide()
    {
        HiddenWords = true;
    }
}
