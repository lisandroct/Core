namespace lisandroct.Core.Utils
{
    public static class FloatExtensions
    {
        public static float Map(this float x, float x1, float x2, float y1, float y2) {
            float m = (y2 - y1) / (x2 - x1);
            float c = y1 - m * x1;

            return m * x + c;
        }

        public static float Map(this byte x, byte x1, byte x2, float y1, float y2) => Map((float) x, (float)x1, (float)x2, y1, y2);
        public static float Map(this int x, int x1, int x2, float y1, float y2) => Map((float) x, (float)x1, (float)x2, y1, y2);
    }
}