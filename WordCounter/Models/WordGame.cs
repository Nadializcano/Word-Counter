namespace WordCounter.Models
{
  public class RepeatCounter
  {

    private string _letter;

    public RepeatCounter (string letter)
    {
      _letter = letter;
    }

    public string GetLetter()
    {
      return _letter;
    }
  }
}
