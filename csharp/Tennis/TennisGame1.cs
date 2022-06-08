namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private readonly Player player1;
        private readonly Player player2;

        public TennisGame1(string player1Name, string player2Name)
        {
            player1 = Player.CreatePlayer(player1Name);
            player2 = Player.CreatePlayer(player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                player1.Score += 1;
            else
                player2.Score += 1;
        }

        public string GetScore()
        {
            var sameScore = player1.Score == player2.Score;
            if (sameScore)
            {
                return GetScoreWhenIsEqual();
            }
            if (player1.Score >= 4 || player2.Score >= 4)
            {
                return GetScoreWhenDeuceOrWin();
            }
            return $"{player1.GetScore()}-{player2.GetScore()}";
        }

        private string GetScoreWhenDeuceOrWin()
        {
            var minusResult = player1.Score - player2.Score;
            return minusResult switch
            {
                1 => "Advantage player1",
                -1 => "Advantage player2",
                >= 2 => "Win for player1",
                _ => "Win for player2"
            };
        }

        private string GetScoreWhenIsEqual()
        {
            return player1.Score switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };
        }
    }
}

