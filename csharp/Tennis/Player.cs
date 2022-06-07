namespace Tennis;

public class Player
{
    public int Score { get; set; }
    public string Name { get; }

    private Player(string name)
    {
        this.Name = name;
        this.Score = 0;
    }

    public static Player CreatePlayer(string name)
    {
        return new Player(name);
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