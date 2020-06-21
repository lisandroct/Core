namespace lisandroct.Core.Random
{
    public class PRNG
    {
		public int Seed { get; private set; }
		private System.Random random { get; }

		public PRNG() {
			random = new System.Random();
		}

		public PRNG(string seed) : this(seed.GetHashCode()) { }

		public PRNG(int seed) {
			Seed = seed;
			random = new System.Random(seed);
		}

		public int Int() => random.Next();

		/// <summary>Returns a random number between 0 (inclusive) and the specified value (exclusive).</summary>
		public int Int(int range) => random.Next(range);

		///  <summary>Returns a random number between <c>start</c> (inclusive) and <c>end</c> (exclusive).</summary>
		public int Int(int start, int end) => random.Next(start, end);

		public float Float() => (float)random.NextDouble();

		/// <summary>Returns a random number between 0 (inclusive) and the specified value (exclusive).</summary> 
		public float Float(float range) {
			return Float() * range;
		}

		/// <summary>Returns a random number between <c>start</c> (inclusive) and <c>end</c> (exclusive).</summary>
		public float Float(float start, float end) {
			return start + Float() * (end - start);
		}

		/// <summary>Returns a triangularly distributed random number between -1.0 (exclusive) and 1.0 (exclusive), where values around zero are more likely.</summary>
		public float FloatTriangular() {
			return Float() - Float();
		}

		/// <summary>Returns a triangularly distributed random number between <c>-max</c> (exclusive) and <c>max</c> (exclusive), where values around zero are more likely.</summary>
		public float FloatTriangular(float max) {
			return (Float() - Float()) * max;
		}

		/// <summary>Returns a triangularly distributed random number between <c>min</c> (inclusive) and <c>max</c> (exclusive), where the
		///		<c>mode</c> argument defaults to the midpoint between the bounds, giving a symmetric distribution.</summary>
		public float FloatTriangular(float min, float max) {
			return FloatTriangular(min, max, (min + max) * 0.5f);
		}

		/// <summary>Returns a triangularly distributed random number between <c>min</c> (inclusive) and <c>max</c> (exclusive), where values
		///		around <c>mode</c> are more likely.</summary>
		public float FloatTriangular(float min, float max, float mode) {
			float u = Float();
			float d = max - min;
			if(u <= (mode - min) / d)
				return min + UnityEngine.Mathf.Sqrt(u * d * (mode - min));
			return max - UnityEngine.Mathf.Sqrt((1 - u) * d * (max - mode));
		}

		/// <summary>Returns a random boolean value.</summary>
		public bool Bool() {
			return Bool(0.5f);
		}

		/// <summary>Returns true if a random value between 0 and 1 is less than the specified value.</summary>
		public bool Bool(float chance) {
			return Float() < chance;
		}

		/// <summary>Returns -1 or 1, randomly.</summary>
		public int Sign() {
			return 1 | (Int() >> 31);
		}
	}
}
 