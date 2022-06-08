namespace Tennis;

public class Player
{
    public int Score { get; set; }

    private Player()
    {
        this.Score = 0;
    }

    public static Player CreatePlayer()
    {
        return new Player();
    }

    public string GetScore()
    {
        switch (Score)
        {
            case 0:
                return "Love";
            case 1:
                return "Fifteen";
            case 2:
                return "Thirty";
            default:
                return "Forty";
        }
    }
}