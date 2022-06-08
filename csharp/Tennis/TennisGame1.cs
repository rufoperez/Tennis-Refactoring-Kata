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
            string score = "";
            var sameScore = player1.Score == player2.Score;
            if (sameScore)
            {
                score = GetScoreWhenIsEqual();
            }
            else if (player1.Score >= 4 || player2.Score >= 4)
            {
                score = GetScoreWhenDeuceOrWin();
            }
            else
            {
                score = $"{player1.GetScore()}-{player2.GetScore()}";
            }
            return score;
        }

        private string GetScoreWhenDeuceOrWin()
        {
            string score;
            var minusResult = player1.Score - player2.Score;
            if (minusResult == 1) score = "Advantage player1";
            else if (minusResult == -1) score = "Advantage player2";
            else if (minusResult >= 2) score = "Win for player1";
            else score = "Win for player2";
            return score;
        }

        private string GetScoreWhenIsEqual()
        {
            string score;
            switch (player1.Score)
            {
                case 0:
                    score = "Love-All";
                    break;
                case 1:
                    score = "Fifteen-All";
                    break;
                case 2:
                    score = "Thirty-All";
                    break;
                default:
                    score = "Deuce";
                    break;
            }

            return score;
        }
    }
}

