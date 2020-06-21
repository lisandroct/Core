using UnityEngine;

namespace lisandroct.Core.Random
{
    public static class Noise
    {
        public static float Get(float x, float y, float scale, Vector2 offset) {
            Vector2 sample = new Vector2(x, y) * scale + offset;
            float perlinValue = Mathf.PerlinNoise(sample.x, sample.y);

            return Mathf.Clamp(perlinValue, 0f, 1f);
        }

        public static float[,] GetMap(int width, int depth, int seed, float scale, int octaves, float persistance, float lacunarity, Vector2 offset) {
            float[,] map = new float[width, depth];

            PRNG random = new PRNG(seed);
            Vector2[] offsets = new Vector2[octaves];
            for(int i = 0; i < octaves; i++) {
                float x = random.Float(-100000, 100000) + offset.x;
                float y = random.Float(-100000, 100000) + offset.y;
                offsets[i] = new Vector2(x, y);
            }

            float hWidth = width * 0.5f;
            float hDepth = depth * 0.5f;

            float min = float.MaxValue;
            float max = float.MinValue;
            for(int x = 0; x < width; x++) {
                for(int y = 0; y < depth; y++) {
                    float amplitude = 1;
                    float frequency = 1;
                    float height = 0;

                    for(int i = 0; i < octaves; i++) {
                        Vector2 sample = new Vector2(x - hWidth, y - hDepth) * scale * frequency + offsets[i];

                        float perlinValue = Mathf.PerlinNoise(sample.x, sample.y) * 2 - 1;
                        height += perlinValue * amplitude;

                        amplitude *= persistance;
                        frequency *= lacunarity;
                    }

                    if(height < min) {
                        min = height;
                    }
                    if(height > max) {
                        max = height;
                    }

                    map[x, y] = height;
                }
            }

            for(int x = 0; x < width; x++) {
                for(int y = 0; y < depth; y++) {
                    map[x, y] = Mathf.InverseLerp(min, max, map[x, y]);
                }
            }

            return map;
        }
    }
}