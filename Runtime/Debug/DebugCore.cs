using UnityEngine;
using lisandroct.Core.Utils;

namespace lisandroct.Core.Debug
{
    public static class DebugCore
    {
        public static void DrawRect(Rect rect) => DrawRect(rect, Color.white);

        public static void DrawRect(Rect rect, Color color) {
            Vector3 a = new Vector2(rect.xMin, rect.yMin).sX0Y();
            Vector3 b = new Vector2(rect.xMax, rect.yMin).sX0Y();
            Vector3 c = new Vector2(rect.xMax, rect.yMax).sX0Y();
            Vector3 d = new Vector2(rect.xMin, rect.yMax).sX0Y();

            UnityEngine.Debug.DrawLine(a, b, color);
            UnityEngine.Debug.DrawLine(b, c, color);
            UnityEngine.Debug.DrawLine(c, d, color);
            UnityEngine.Debug.DrawLine(d, a, color);
        }
    }
}