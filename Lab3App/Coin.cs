using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Coin : Treasure
	{
		private int value;
		public int Value
		{
			get { return this.value; }
			set { this.value = value; }
		}
		public Coin(string description,int score, int value): base(description,score)
		{
			this.value = value;
		}

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
			UpdateTotalValue();
        }

		public void UpdateTotalValue()
		{
			base.Board.TotalValue += this.value;
		}

        public override void Display()
        {
			Console.WriteLine("Coin " + Description + " is displayed");
        }

    }
}

