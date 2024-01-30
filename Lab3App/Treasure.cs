using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Treasure : Collectable
	{
		private int score;
		public int Score
		{
			get { return this.score; }
			set { this.score = value; }
		}
		public Treasure(string description, int score): base( description)
		{
			this.score = score;
		}

		public void UpdateTotalScore()
		{
			base.Board.TotalScore += this.score;
		}

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
			UpdateTotalScore();
			Console.WriteLine("Total Score is updated to: " + base.Board.TotalScore);
        }
    }
}

