public class Reference
{
    private int _verse;
    private int _chapter;
    private string _book;

    public Reference(){
        _book = "Nefi";
        _chapter = 3;
        _verse = 1;
        }

    public Reference(int verse)
    {
        _book = "Nefi";
        _chapter = 3;
        _verse = verse;
    }

    public string GetScripture(){
        string scripture = _book + " " + _chapter + " " + _verse;
        return scripture;
    }
}