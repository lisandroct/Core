using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lisandroct.Core.Utils
{
    public static class VectorExtensions
    {
        public static bool IsBehind(this Vector2 vector, Vector2 other) => Vector2.Dot(vector, other) < 0;
        public static bool IsBehind(this Vector2 vector, Vector3 other) => Vector2.Dot(vector, other) < 0;
        public static bool IsBehind(this Vector3 vector, Vector2 other) => Vector2.Dot(vector, other) < 0;
        public static bool IsBehind(this Vector3 vector, Vector3 other) => Vector2.Dot(vector, other) < 0;

        public static Vector2 With(this Vector2 vector, float? x = null, float? y = null) {
            if(x != null) {
                vector.x = x.Value;
            }
            if(y != null) {
                vector.y = y.Value;
            }

            return vector;
        }

        public static Vector3 With(this Vector3 vector, float? x = null, float? y = null, float? z = null) {
            if(x != null) {
                vector.x = x.Value;
            }
            if(y != null) {
                vector.y = y.Value;
            }
            if(z != null) {
                vector.z = z.Value;
            }

            return vector;
        }

        public static Vector4 With(this Vector4 vector, float? x = null, float? y = null, float? z = null, float? w = null) {
            if(x != null) {
                vector.x = x.Value;
            }
            if(y != null) {
                vector.y = y.Value;
            }
            if(z != null) {
                vector.z = z.Value;
            }
            if(w != null) {
                vector.w = w.Value;
            }

            return vector;
        }

        public static bool Contains(this Vector2 vector, float value) => value >= vector.x && value <= vector.y;
    }
}