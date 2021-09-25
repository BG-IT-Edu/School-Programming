using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
   public class Dough
    {
        private const double MIN_WEIGHT = 1;
        private const double MAX_WEIGHT = 200;

        private const double white = 1.5;
        private const double wholegrain = 1.0;
        private const double crispy = 0.9;
        private const double chewy = 1.1;
        private const double homemade = 1.0;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new InvalidOperationException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new InvalidOperationException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < MIN_WEIGHT || value > MAX_WEIGHT)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double calories = 0.0;

            if (this.FlourType.ToLower() == "white" && this.BakingTechnique.ToLower() == "crispy")
            {
                calories = (2 * this.Weight) * white * crispy;
            }

            else if (this.FlourType.ToLower() == "white" && this.BakingTechnique.ToLower() == "chewy")
            {
                calories = (2 * this.Weight) * white * chewy;
            }

            else if (this.FlourType.ToLower() == "white" && this.BakingTechnique.ToLower() == "homemade")
            {
                calories = (2 * this.Weight) * white * homemade;
            }

            else if (this.FlourType.ToLower() == "wholegrain" && this.BakingTechnique.ToLower() == "crispy")
            {
                calories = (2 * this.Weight) * wholegrain * crispy;
            }

            else if (this.FlourType.ToLower() == "wholegrain" && this.BakingTechnique.ToLower() == "chewy")
            {
                calories = (2 * this.Weight) * wholegrain * chewy;
            }

            else if (this.FlourType.ToLower() == "wholegrain" && this.BakingTechnique.ToLower() == "homemade")
            {
                calories = (2 * this.Weight) * wholegrain * homemade;
            }

            return calories;

        }
    }
}
