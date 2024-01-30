using System;
namespace Lab3App
{
	public class CollectionBoard
	{
		private int totalScore;
		private int totalValue;
		public int TotalScore
		{
			get { return totalScore; }
			set { this.totalScore = value; }
		}
        public int TotalValue
		{
            get { return totalValue; }
            set { this.totalValue = value; }
        }

        public CollectionBoard()
		{
			this.totalScore = 0;
			this.totalValue = 0;
		}
	}
}

