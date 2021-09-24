using System;
using System.Collections.Generic;
using System.Text;

namespace FootbalTeamGenerator
{
    public class Player
    {
        private string name;

        public Player(string name,Stat stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        public string Name
        {
            get 
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public Stat Stats { get; set; }
    }
}
