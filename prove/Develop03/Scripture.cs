public class Scripture
{
    //public string _reference;

    public void GetScripture() {
        Reference reference = new Reference(2);

        string text = reference.GetScripture();

        Console.WriteLine(text);


    }
}