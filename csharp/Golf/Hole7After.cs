namespace Trivia
{
    public class Hole7After
    {
        private int[] places = new int[6];
        private int currentPlayer = 0;

		private readonly string[] board = new string[] {
			"Pop", "Science", "Sports", "Rock",
			"Pop", "Science", "Sports", "Rock",
			"Pop", "Science", "Sports", "Rock" };

        internal string currentCategory()
        {
			int position = places[currentPlayer];
			return board[position];
        }

    }

}
