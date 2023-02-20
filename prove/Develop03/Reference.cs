public class Reference
{
    private int _chapter;
    private string _book;
    private int _start;
    private int _end;

    public Reference()
    {
        _book = "Nefi";
        _chapter = 3;
        _start = 1;
        _end = _start;
    }

    public Reference(string book)
    {
        _book = book;
        _chapter = 3;
        _start = 1;
        _end = _start;
    }

    public Reference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _start = 1;
        _end = _start;
    }

    public Reference(string book, int chapter, int start)
    {
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = _start;
    }

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = end;
    }

    public string GetReference()
    {
        return _book + " " + _chapter + ":" + _start;
    }

}