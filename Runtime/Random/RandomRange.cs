using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lisandroct.Core.Random
{
    public static class RandomRange
    {
        public static float GetRandomValue(this Vector2 vector) => UnityEngine.Random.Range(vector.x, vector.y);
        public static float GetRandomValue(this Vector2Int vector) => UnityEngine.Random.Range(vector.x, vector.y);
    }
}