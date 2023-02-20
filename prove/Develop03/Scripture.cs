public class Scripture
{
    private string _reference;
    private string _scriptureText;



    public void GetRenderedText() {
        Reference reference = new Reference("Nefi", 2, 1, 3); // Nefi 2:1-3

        string learnScripture = reference.GetReference();


        
    }
}