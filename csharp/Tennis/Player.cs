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
}