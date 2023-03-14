public class Score
{
    private int _score;

    public Score()
    {
        _score = 0;
    }

    public void SetScore(int score)
    {
        _score = _score + score;
    }

    public int GetScore()
    {
        return _score;
    }

}