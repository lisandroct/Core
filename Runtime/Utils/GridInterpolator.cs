using UnityEngine;

namespace lisandroct.Core.Utils
{
    public static class GridInterpolator {
        public static void CatmullRom(this float[,] grid, int step, float alpha) {
            int width = grid.GetLength(0);
            int depth = grid.GetLength(1);

            // Horizontal
            for(int y = 0; y < depth; y += step) {
                for(int x = 0; x < width - 1; x += step) {
                    int a = x - step;
                    int b = x;
                    int c = x + step;
                    int d = c + step;

                    float h1 = grid[b, y];
                    float h2 = grid[c, y];
                    float h0;
                    if(a >= 0) {
                        h0 = grid[a, y];
                    } else {
                        h0 = h1 + (h1 - h2);
                    }
                    float h3;
                    if(d < width) {
                        h3 = grid[d, y];
                    } else {
                        h3 = h2 + (h2 - h1);
                    }

                    float t0 = 0.0f;
                    float t1 = GetT(t0, h0, h1);
                    float t2 = GetT(t1, h1, h2);
                    float t3 = GetT(t2, h2, h3);

                    float s = (t2 - t1) / (step + 1);
                    for(int i = 0; i < step; i++) {
                        float t = t1 + i * s;
                        float A1 = (t1 - t) / (t1 - t0) * h0 + (t - t0) / (t1 - t0) * h1;
                        float A2 = (t2 - t) / (t2 - t1) * h1 + (t - t1) / (t2 - t1) * h2;
                        float A3 = (t3 - t) / (t3 - t2) * h2 + (t - t2) / (t3 - t2) * h3;

                        float B1 = (t2 - t) / (t2 - t0) * A1 + (t - t0) / (t2 - t0) * A2;
                        float B2 = (t3 - t) / (t3 - t1) * A2 + (t - t1) / (t3 - t1) * A3;

                        float C = (t2 - t) / (t2 - t1) * B1 + (t - t1) / (t2 - t1) * B2;

                        grid[b + i, y] = C;
                    }
                }
            }

            // Vertical
            for(int x = 0; x < width; x++) {
                for(int y = 0; y < depth - 1; y += step) {
                    int a = y - step;
                    int b = y;
                    int c = y + step;
                    int d = c + step;

                    float h1 = grid[x, b];
                    float h2 = grid[x, c];
                    float h0;
                    if(a >= 0) {
                        h0 = grid[x, a];
                    } else {
                        h0 = h1 + (h1 - h2);
                    }
                    float h3;
                    if(d < depth) {
                        h3 = grid[x, d];
                    } else {
                        h3 = h2 + (h2 - h1);
                    }

                    float t0 = 0.0f;
                    float t1 = GetT(t0, h0, h1);
                    float t2 = GetT(t1, h1, h2);
                    float t3 = GetT(t2, h2, h3);

                    float s = (t2 - t1) / (step + 1);
                    for(int i = 0; i < step; i++) {
                        float t = t1 + i * s;
                        float A1 = (t1 - t) / (t1 - t0) * h0 + (t - t0) / (t1 - t0) * h1;
                        float A2 = (t2 - t) / (t2 - t1) * h1 + (t - t1) / (t2 - t1) * h2;
                        float A3 = (t3 - t) / (t3 - t2) * h2 + (t - t2) / (t3 - t2) * h3;

                        float B1 = (t2 - t) / (t2 - t0) * A1 + (t - t0) / (t2 - t0) * A2;
                        float B2 = (t3 - t) / (t3 - t1) * A2 + (t - t1) / (t3 - t1) * A3;

                        float C = (t2 - t) / (t2 - t1) * B1 + (t - t1) / (t2 - t1) * B2;

                        grid[x, b + i] = C;
                    }
                }
            }

            float GetT(float t, float h0, float h1) {
                float c;
                if(Mathf.Approximately(alpha, 0)) {
                    c = 1;
                } else {
                    float s = h1 - h0;
                    float a = s * s;
                    float b = Mathf.Pow(a, 0.5f);
                    if(Mathf.Approximately(alpha, 1)) {
                        c = b;
                    } else {
                        c = Mathf.Pow(b, alpha);
                    }
                }

                return c + t;
            }
        }

        public static void Smooth(this float[,] grid, float t) {
            int width = grid.GetLength(0);
            int depth = grid.GetLength(1);

            for(int x = 1; x < width - 1; x++) {
                for(int y = 1; y < depth - 1; y++) {
                    float a = grid[x - 1, y - 1];
                    float b = grid[x, y - 1];
                    float c = grid[x + 1, y - 1];
                    float d = grid[x + 1, y];
                    float e = grid[x + 1, y + 1];
                    float f = grid[x, y + 1];
                    float g = grid[x - 1, y + 1];
                    float h = grid[x - 1, y];

                    float neighbors = (a + b + c + d + e + f + g + h) * 0.125f;

                    grid[x, y] = Mathf.Lerp(grid[x, y], neighbors, t);
                }
            }
        }
    }
}