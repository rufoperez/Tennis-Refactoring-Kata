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
        return Score switch
        {
            0 => "Love",
            1 => "Fifteen",
            2 => "Thirty",
            _ => "Forty"
        };
    }
}