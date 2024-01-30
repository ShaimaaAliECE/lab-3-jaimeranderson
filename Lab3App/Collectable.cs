using System;
using System.Collections.Generic;
namespace Lab3App
{
	public abstract class Collectable : Displayable
	{
		private string description;
		private CollectionBoard board;

		public abstract void Display();

		public CollectionBoard Board
		{
			get
			{return this.board;}
			set
			{this.board = value;}
		}

        public string Description
        {
            get
            { return this.description; }
            set
            { this.description = value; }
        }

        public Collectable(string description)
		{
			this.description = description;
		}

		public virtual void AddMe(List<Collectable> list)
		{
			list.Add(this);
			Console.WriteLine(Description + " Collected, Congrats!!!!");
		}


	}
}

