using UnityEngine;

namespace lisandroct.Core.Utils
{
    public class MinMaxAttribute : PropertyAttribute {
        public float MinLimit { get; private set; }
        public float MaxLimit { get; private set; }
        public float MinTopLimit { get; private set; }
        public float MaxBottomLimit { get; private set; }

        public MinMaxAttribute(int min, int max) : this(min, max, max, min) { }

        public MinMaxAttribute(float min, float max) : this(min, max, max, min) { }

        public MinMaxAttribute(int min, int max, int center) : this((float)min, max, center) { }

        public MinMaxAttribute(float min, float max, float center) : this(min, max, center, center) { }

        public MinMaxAttribute(int min, int max, int minTopLimit, int maxBottomLimit) : this((float)min, max, minTopLimit, maxBottomLimit) { }

        public MinMaxAttribute(float min, float max, float minTopLimit, float maxBottomLimit) {
            MinLimit = min;
            MaxLimit = max;

            minTopLimit = Mathf.Clamp(minTopLimit, min, max);
            maxBottomLimit = Mathf.Clamp(maxBottomLimit, min, max);

            MinTopLimit = minTopLimit;
            MaxBottomLimit = maxBottomLimit;
        }
    }
}   