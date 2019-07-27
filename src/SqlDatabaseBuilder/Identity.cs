using System;
namespace Xtrimmer.SqlDatabaseBuilder
{
    public class Identity :  DatabaseObject
    {
        private int seed;
        private int increment;

        public Identity() : this(1, 1) { }

        public Identity(int seed, int increment) : base(null)
        {
            if (increment < 1) throw new InvalidIdentityException("Increment value must be greater than 0");
            this.seed = seed;
            this.increment = increment;
        }

        internal override string SqlDefinition
        {
            get
            {
                string identityParameters = seed < 1 || increment < 1 ? $"({seed}, {increment})" : "";

                return $" IDENTITY{identityParameters}";
            }
        }
    }
}
