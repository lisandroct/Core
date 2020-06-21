﻿using UnityEngine;

namespace lisandroct.Core.Utils
{
    public static class VectorIntSwizzling
    {
        public static Vector2Int sXX(this Vector2Int vector) => new Vector2Int(vector.x, vector.x);
        public static Vector2Int sXY(this Vector2Int vector) => new Vector2Int(vector.x, vector.y);
        public static Vector2Int sXZ(this Vector2Int vector) => new Vector2Int(vector.x, 0);
        public static Vector2Int sXW(this Vector2Int vector) => new Vector2Int(vector.x, 0);
        public static Vector2Int sX0(this Vector2Int vector) => new Vector2Int(vector.x, 0);
        public static Vector2Int sYX(this Vector2Int vector) => new Vector2Int(vector.y, vector.x);
        public static Vector2Int sYY(this Vector2Int vector) => new Vector2Int(vector.y, vector.y);
        public static Vector2Int sYZ(this Vector2Int vector) => new Vector2Int(vector.y, 0);
        public static Vector2Int sYW(this Vector2Int vector) => new Vector2Int(vector.y, 0);
        public static Vector2Int sY0(this Vector2Int vector) => new Vector2Int(vector.y, 0);
        public static Vector2Int sZX(this Vector2Int vector) => new Vector2Int(0, vector.x);
        public static Vector2Int sZY(this Vector2Int vector) => new Vector2Int(0, vector.y);
        public static Vector2Int sZZ(this Vector2Int vector) => new Vector2Int(0, 0);
        public static Vector2Int sZW(this Vector2Int vector) => new Vector2Int(0, 0);
        public static Vector2Int sZ0(this Vector2Int vector) => new Vector2Int(0, 0);
        public static Vector2Int sWX(this Vector2Int vector) => new Vector2Int(0, vector.x);
        public static Vector2Int sWY(this Vector2Int vector) => new Vector2Int(0, vector.y);
        public static Vector2Int sWZ(this Vector2Int vector) => new Vector2Int(0, 0);
        public static Vector2Int sWW(this Vector2Int vector) => new Vector2Int(0, 0);
        public static Vector2Int sW0(this Vector2Int vector) => new Vector2Int(0, 0);
        public static Vector2Int s0X(this Vector2Int vector) => new Vector2Int(0, vector.x);
        public static Vector2Int s0Y(this Vector2Int vector) => new Vector2Int(0, vector.y);
        public static Vector2Int s0Z(this Vector2Int vector) => new Vector2Int(0, 0);
        public static Vector2Int s0W(this Vector2Int vector) => new Vector2Int(0, 0);
        public static Vector2Int s00(this Vector2Int vector) => new Vector2Int(0, 0);

        public static Vector3Int sXXX(this Vector2Int vector) => new Vector3Int(vector.x, vector.x, vector.x);
        public static Vector3Int sXXY(this Vector2Int vector) => new Vector3Int(vector.x, vector.x, vector.y);
        public static Vector3Int sXXZ(this Vector2Int vector) => new Vector3Int(vector.x, vector.x, 0);
        public static Vector3Int sXXW(this Vector2Int vector) => new Vector3Int(vector.x, vector.x, 0);
        public static Vector3Int sXX0(this Vector2Int vector) => new Vector3Int(vector.x, vector.x, 0);
        public static Vector3Int sXYX(this Vector2Int vector) => new Vector3Int(vector.x, vector.y, vector.x);
        public static Vector3Int sXYY(this Vector2Int vector) => new Vector3Int(vector.x, vector.y, vector.y);
        public static Vector3Int sXYZ(this Vector2Int vector) => new Vector3Int(vector.x, vector.y, 0);
        public static Vector3Int sXYW(this Vector2Int vector) => new Vector3Int(vector.x, vector.y, 0);
        public static Vector3Int sXY0(this Vector2Int vector) => new Vector3Int(vector.x, vector.y, 0);
        public static Vector3Int sXZX(this Vector2Int vector) => new Vector3Int(vector.x, 0, vector.x);
        public static Vector3Int sXZY(this Vector2Int vector) => new Vector3Int(vector.x, 0, vector.y);
        public static Vector3Int sXZZ(this Vector2Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sXZW(this Vector2Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sXZ0(this Vector2Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sXWX(this Vector2Int vector) => new Vector3Int(vector.x, 0, vector.x);
        public static Vector3Int sXWY(this Vector2Int vector) => new Vector3Int(vector.x, 0, vector.y);
        public static Vector3Int sXWZ(this Vector2Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sXWW(this Vector2Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sXW0(this Vector2Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sX0X(this Vector2Int vector) => new Vector3Int(vector.x, 0, vector.x);
        public static Vector3Int sX0Y(this Vector2Int vector) => new Vector3Int(vector.x, 0, vector.y);
        public static Vector3Int sX0Z(this Vector2Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sX0W(this Vector2Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sX00(this Vector2Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sYXX(this Vector2Int vector) => new Vector3Int(vector.y, vector.x, vector.x);
        public static Vector3Int sYXY(this Vector2Int vector) => new Vector3Int(vector.y, vector.x, vector.y);
        public static Vector3Int sYXZ(this Vector2Int vector) => new Vector3Int(vector.y, vector.x, 0);
        public static Vector3Int sYXW(this Vector2Int vector) => new Vector3Int(vector.y, vector.x, 0);
        public static Vector3Int sYX0(this Vector2Int vector) => new Vector3Int(vector.y, vector.x, 0);
        public static Vector3Int sYYX(this Vector2Int vector) => new Vector3Int(vector.y, vector.y, vector.x);
        public static Vector3Int sYYY(this Vector2Int vector) => new Vector3Int(vector.y, vector.y, vector.y);
        public static Vector3Int sYYZ(this Vector2Int vector) => new Vector3Int(vector.y, vector.y, 0);
        public static Vector3Int sYYW(this Vector2Int vector) => new Vector3Int(vector.y, vector.y, 0);
        public static Vector3Int sYY0(this Vector2Int vector) => new Vector3Int(vector.y, vector.y, 0);
        public static Vector3Int sYZX(this Vector2Int vector) => new Vector3Int(vector.y, 0, vector.x);
        public static Vector3Int sYZY(this Vector2Int vector) => new Vector3Int(vector.y, 0, vector.y);
        public static Vector3Int sYZZ(this Vector2Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sYZW(this Vector2Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sYZ0(this Vector2Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sYWX(this Vector2Int vector) => new Vector3Int(vector.y, 0, vector.x);
        public static Vector3Int sYWY(this Vector2Int vector) => new Vector3Int(vector.y, 0, vector.y);
        public static Vector3Int sYWZ(this Vector2Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sYWW(this Vector2Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sYW0(this Vector2Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sY0X(this Vector2Int vector) => new Vector3Int(vector.y, 0, vector.x);
        public static Vector3Int sY0Y(this Vector2Int vector) => new Vector3Int(vector.y, 0, vector.y);
        public static Vector3Int sY0Z(this Vector2Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sY0W(this Vector2Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sY00(this Vector2Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sZXX(this Vector2Int vector) => new Vector3Int(0, vector.x, vector.x);
        public static Vector3Int sZXY(this Vector2Int vector) => new Vector3Int(0, vector.x, vector.y);
        public static Vector3Int sZXZ(this Vector2Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int sZXW(this Vector2Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int sZX0(this Vector2Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int sZYX(this Vector2Int vector) => new Vector3Int(0, vector.y, vector.x);
        public static Vector3Int sZYY(this Vector2Int vector) => new Vector3Int(0, vector.y, vector.y);
        public static Vector3Int sZYZ(this Vector2Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int sZYW(this Vector2Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int sZY0(this Vector2Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int sZZX(this Vector2Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int sZZY(this Vector2Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int sZZZ(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sZZW(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sZZ0(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sZWX(this Vector2Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int sZWY(this Vector2Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int sZWZ(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sZWW(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sZW0(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sZ0X(this Vector2Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int sZ0Y(this Vector2Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int sZ0Z(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sZ0W(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sZ00(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sWXX(this Vector2Int vector) => new Vector3Int(0, vector.x, vector.x);
        public static Vector3Int sWXY(this Vector2Int vector) => new Vector3Int(0, vector.x, vector.y);
        public static Vector3Int sWXZ(this Vector2Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int sWXW(this Vector2Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int sWX0(this Vector2Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int sWYX(this Vector2Int vector) => new Vector3Int(0, vector.y, vector.x);
        public static Vector3Int sWYY(this Vector2Int vector) => new Vector3Int(0, vector.y, vector.y);
        public static Vector3Int sWYZ(this Vector2Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int sWYW(this Vector2Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int sWY0(this Vector2Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int sWZX(this Vector2Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int sWZY(this Vector2Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int sWZZ(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sWZW(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sWZ0(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sWWX(this Vector2Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int sWWY(this Vector2Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int sWWZ(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sWWW(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sWW0(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sW0X(this Vector2Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int sW0Y(this Vector2Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int sW0Z(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sW0W(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sW00(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s0XX(this Vector2Int vector) => new Vector3Int(0, vector.x, vector.x);
        public static Vector3Int s0XY(this Vector2Int vector) => new Vector3Int(0, vector.x, vector.y);
        public static Vector3Int s0XZ(this Vector2Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int s0XW(this Vector2Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int s0X0(this Vector2Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int s0YX(this Vector2Int vector) => new Vector3Int(0, vector.y, vector.x);
        public static Vector3Int s0YY(this Vector2Int vector) => new Vector3Int(0, vector.y, vector.y);
        public static Vector3Int s0YZ(this Vector2Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int s0YW(this Vector2Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int s0Y0(this Vector2Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int s0ZX(this Vector2Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int s0ZY(this Vector2Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int s0ZZ(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s0ZW(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s0Z0(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s0WX(this Vector2Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int s0WY(this Vector2Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int s0WZ(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s0WW(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s0W0(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s00X(this Vector2Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int s00Y(this Vector2Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int s00Z(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s00W(this Vector2Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s000(this Vector2Int vector) => new Vector3Int(0, 0, 0);



        public static Vector2Int sXX(this Vector3Int vector) => new Vector2Int(vector.x, vector.x);
        public static Vector2Int sXY(this Vector3Int vector) => new Vector2Int(vector.x, vector.y);
        public static Vector2Int sXZ(this Vector3Int vector) => new Vector2Int(vector.x, vector.z);
        public static Vector2Int sXW(this Vector3Int vector) => new Vector2Int(vector.x, 0);
        public static Vector2Int sX0(this Vector3Int vector) => new Vector2Int(vector.x, 0);
        public static Vector2Int sYX(this Vector3Int vector) => new Vector2Int(vector.y, vector.x);
        public static Vector2Int sYY(this Vector3Int vector) => new Vector2Int(vector.y, vector.y);
        public static Vector2Int sYZ(this Vector3Int vector) => new Vector2Int(vector.y, vector.z);
        public static Vector2Int sYW(this Vector3Int vector) => new Vector2Int(vector.y, 0);
        public static Vector2Int sY0(this Vector3Int vector) => new Vector2Int(vector.y, 0);
        public static Vector2Int sZX(this Vector3Int vector) => new Vector2Int(vector.z, vector.x);
        public static Vector2Int sZY(this Vector3Int vector) => new Vector2Int(vector.z, vector.y);
        public static Vector2Int sZZ(this Vector3Int vector) => new Vector2Int(vector.z, vector.z);
        public static Vector2Int sZW(this Vector3Int vector) => new Vector2Int(vector.z, 0);
        public static Vector2Int sZ0(this Vector3Int vector) => new Vector2Int(vector.z, 0);
        public static Vector2Int sWX(this Vector3Int vector) => new Vector2Int(0, vector.x);
        public static Vector2Int sWY(this Vector3Int vector) => new Vector2Int(0, vector.y);
        public static Vector2Int sWZ(this Vector3Int vector) => new Vector2Int(0, vector.z);
        public static Vector2Int sWW(this Vector3Int vector) => new Vector2Int(0, 0);
        public static Vector2Int sW0(this Vector3Int vector) => new Vector2Int(0, 0);
        public static Vector2Int s0X(this Vector3Int vector) => new Vector2Int(0, vector.x);
        public static Vector2Int s0Y(this Vector3Int vector) => new Vector2Int(0, vector.y);
        public static Vector2Int s0Z(this Vector3Int vector) => new Vector2Int(0, vector.z);
        public static Vector2Int s0W(this Vector3Int vector) => new Vector2Int(0, 0);
        public static Vector2Int s00(this Vector3Int vector) => new Vector2Int(0, 0);

        public static Vector3Int sXXX(this Vector3Int vector) => new Vector3Int(vector.x, vector.x, vector.x);
        public static Vector3Int sXXY(this Vector3Int vector) => new Vector3Int(vector.x, vector.x, vector.y);
        public static Vector3Int sXXZ(this Vector3Int vector) => new Vector3Int(vector.x, vector.x, vector.z);
        public static Vector3Int sXXW(this Vector3Int vector) => new Vector3Int(vector.x, vector.x, 0);
        public static Vector3Int sXX0(this Vector3Int vector) => new Vector3Int(vector.x, vector.x, 0);
        public static Vector3Int sXYX(this Vector3Int vector) => new Vector3Int(vector.x, vector.y, vector.x);
        public static Vector3Int sXYY(this Vector3Int vector) => new Vector3Int(vector.x, vector.y, vector.y);
        public static Vector3Int sXYZ(this Vector3Int vector) => new Vector3Int(vector.x, vector.y, vector.z);
        public static Vector3Int sXYW(this Vector3Int vector) => new Vector3Int(vector.x, vector.y, 0);
        public static Vector3Int sXY0(this Vector3Int vector) => new Vector3Int(vector.x, vector.y, 0);
        public static Vector3Int sXZX(this Vector3Int vector) => new Vector3Int(vector.x, vector.z, vector.x);
        public static Vector3Int sXZY(this Vector3Int vector) => new Vector3Int(vector.x, vector.z, vector.y);
        public static Vector3Int sXZZ(this Vector3Int vector) => new Vector3Int(vector.x, vector.z, vector.z);
        public static Vector3Int sXZW(this Vector3Int vector) => new Vector3Int(vector.x, vector.z, 0);
        public static Vector3Int sXZ0(this Vector3Int vector) => new Vector3Int(vector.x, vector.z, 0);
        public static Vector3Int sXWX(this Vector3Int vector) => new Vector3Int(vector.x, 0, vector.x);
        public static Vector3Int sXWY(this Vector3Int vector) => new Vector3Int(vector.x, 0, vector.y);
        public static Vector3Int sXWZ(this Vector3Int vector) => new Vector3Int(vector.x, 0, vector.z);
        public static Vector3Int sXWW(this Vector3Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sXW0(this Vector3Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sX0X(this Vector3Int vector) => new Vector3Int(vector.x, 0, vector.x);
        public static Vector3Int sX0Y(this Vector3Int vector) => new Vector3Int(vector.x, 0, vector.y);
        public static Vector3Int sX0Z(this Vector3Int vector) => new Vector3Int(vector.x, 0, vector.z);
        public static Vector3Int sX0W(this Vector3Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sX00(this Vector3Int vector) => new Vector3Int(vector.x, 0, 0);
        public static Vector3Int sYXX(this Vector3Int vector) => new Vector3Int(vector.y, vector.x, vector.x);
        public static Vector3Int sYXY(this Vector3Int vector) => new Vector3Int(vector.y, vector.x, vector.y);
        public static Vector3Int sYXZ(this Vector3Int vector) => new Vector3Int(vector.y, vector.x, vector.z);
        public static Vector3Int sYXW(this Vector3Int vector) => new Vector3Int(vector.y, vector.x, 0);
        public static Vector3Int sYX0(this Vector3Int vector) => new Vector3Int(vector.y, vector.x, 0);
        public static Vector3Int sYYX(this Vector3Int vector) => new Vector3Int(vector.y, vector.y, vector.x);
        public static Vector3Int sYYY(this Vector3Int vector) => new Vector3Int(vector.y, vector.y, vector.y);
        public static Vector3Int sYYZ(this Vector3Int vector) => new Vector3Int(vector.y, vector.y, vector.z);
        public static Vector3Int sYYW(this Vector3Int vector) => new Vector3Int(vector.y, vector.y, 0);
        public static Vector3Int sYY0(this Vector3Int vector) => new Vector3Int(vector.y, vector.y, 0);
        public static Vector3Int sYZX(this Vector3Int vector) => new Vector3Int(vector.y, vector.z, vector.x);
        public static Vector3Int sYZY(this Vector3Int vector) => new Vector3Int(vector.y, vector.z, vector.y);
        public static Vector3Int sYZZ(this Vector3Int vector) => new Vector3Int(vector.y, vector.z, vector.z);
        public static Vector3Int sYZW(this Vector3Int vector) => new Vector3Int(vector.y, vector.z, 0);
        public static Vector3Int sYZ0(this Vector3Int vector) => new Vector3Int(vector.y, vector.z, 0);
        public static Vector3Int sYWX(this Vector3Int vector) => new Vector3Int(vector.y, 0, vector.x);
        public static Vector3Int sYWY(this Vector3Int vector) => new Vector3Int(vector.y, 0, vector.y);
        public static Vector3Int sYWZ(this Vector3Int vector) => new Vector3Int(vector.y, 0, vector.z);
        public static Vector3Int sYWW(this Vector3Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sYW0(this Vector3Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sY0X(this Vector3Int vector) => new Vector3Int(vector.y, 0, vector.x);
        public static Vector3Int sY0Y(this Vector3Int vector) => new Vector3Int(vector.y, 0, vector.y);
        public static Vector3Int sY0Z(this Vector3Int vector) => new Vector3Int(vector.y, 0, vector.z);
        public static Vector3Int sY0W(this Vector3Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sY00(this Vector3Int vector) => new Vector3Int(vector.y, 0, 0);
        public static Vector3Int sZXX(this Vector3Int vector) => new Vector3Int(vector.z, vector.x, vector.x);
        public static Vector3Int sZXY(this Vector3Int vector) => new Vector3Int(vector.z, vector.x, vector.y);
        public static Vector3Int sZXZ(this Vector3Int vector) => new Vector3Int(vector.z, vector.x, vector.z);
        public static Vector3Int sZXW(this Vector3Int vector) => new Vector3Int(vector.z, vector.x, 0);
        public static Vector3Int sZX0(this Vector3Int vector) => new Vector3Int(vector.z, vector.x, 0);
        public static Vector3Int sZYX(this Vector3Int vector) => new Vector3Int(vector.z, vector.y, vector.x);
        public static Vector3Int sZYY(this Vector3Int vector) => new Vector3Int(vector.z, vector.y, vector.y);
        public static Vector3Int sZYZ(this Vector3Int vector) => new Vector3Int(vector.z, vector.y, vector.z);
        public static Vector3Int sZYW(this Vector3Int vector) => new Vector3Int(vector.z, vector.y, 0);
        public static Vector3Int sZY0(this Vector3Int vector) => new Vector3Int(vector.z, vector.y, 0);
        public static Vector3Int sZZX(this Vector3Int vector) => new Vector3Int(vector.z, vector.z, vector.x);
        public static Vector3Int sZZY(this Vector3Int vector) => new Vector3Int(vector.z, vector.z, vector.y);
        public static Vector3Int sZZZ(this Vector3Int vector) => new Vector3Int(vector.z, vector.z, vector.z);
        public static Vector3Int sZZW(this Vector3Int vector) => new Vector3Int(vector.z, vector.z, 0);
        public static Vector3Int sZZ0(this Vector3Int vector) => new Vector3Int(vector.z, vector.z, 0);
        public static Vector3Int sZWX(this Vector3Int vector) => new Vector3Int(vector.z, 0, vector.x);
        public static Vector3Int sZWY(this Vector3Int vector) => new Vector3Int(vector.z, 0, vector.y);
        public static Vector3Int sZWZ(this Vector3Int vector) => new Vector3Int(vector.z, 0, vector.z);
        public static Vector3Int sZWW(this Vector3Int vector) => new Vector3Int(vector.z, 0, 0);
        public static Vector3Int sZW0(this Vector3Int vector) => new Vector3Int(vector.z, 0, 0);
        public static Vector3Int sZ0X(this Vector3Int vector) => new Vector3Int(vector.z, 0, vector.x);
        public static Vector3Int sZ0Y(this Vector3Int vector) => new Vector3Int(vector.z, 0, vector.y);
        public static Vector3Int sZ0Z(this Vector3Int vector) => new Vector3Int(vector.z, 0, vector.z);
        public static Vector3Int sZ0W(this Vector3Int vector) => new Vector3Int(vector.z, 0, 0);
        public static Vector3Int sZ00(this Vector3Int vector) => new Vector3Int(vector.z, 0, 0);
        public static Vector3Int sWXX(this Vector3Int vector) => new Vector3Int(0, vector.x, vector.x);
        public static Vector3Int sWXY(this Vector3Int vector) => new Vector3Int(0, vector.x, vector.y);
        public static Vector3Int sWXZ(this Vector3Int vector) => new Vector3Int(0, vector.x, vector.z);
        public static Vector3Int sWXW(this Vector3Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int sWX0(this Vector3Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int sWYX(this Vector3Int vector) => new Vector3Int(0, vector.y, vector.x);
        public static Vector3Int sWYY(this Vector3Int vector) => new Vector3Int(0, vector.y, vector.y);
        public static Vector3Int sWYZ(this Vector3Int vector) => new Vector3Int(0, vector.y, vector.z);
        public static Vector3Int sWYW(this Vector3Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int sWY0(this Vector3Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int sWZX(this Vector3Int vector) => new Vector3Int(0, vector.z, vector.x);
        public static Vector3Int sWZY(this Vector3Int vector) => new Vector3Int(0, vector.z, vector.y);
        public static Vector3Int sWZZ(this Vector3Int vector) => new Vector3Int(0, vector.z, vector.z);
        public static Vector3Int sWZW(this Vector3Int vector) => new Vector3Int(0, vector.z, 0);
        public static Vector3Int sWZ0(this Vector3Int vector) => new Vector3Int(0, vector.z, 0);
        public static Vector3Int sWWX(this Vector3Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int sWWY(this Vector3Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int sWWZ(this Vector3Int vector) => new Vector3Int(0, 0, vector.z);
        public static Vector3Int sWWW(this Vector3Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sWW0(this Vector3Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sW0X(this Vector3Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int sW0Y(this Vector3Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int sW0Z(this Vector3Int vector) => new Vector3Int(0, 0, vector.z);
        public static Vector3Int sW0W(this Vector3Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int sW00(this Vector3Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s0XX(this Vector3Int vector) => new Vector3Int(0, vector.x, vector.x);
        public static Vector3Int s0XY(this Vector3Int vector) => new Vector3Int(0, vector.x, vector.y);
        public static Vector3Int s0XZ(this Vector3Int vector) => new Vector3Int(0, vector.x, vector.z);
        public static Vector3Int s0XW(this Vector3Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int s0X0(this Vector3Int vector) => new Vector3Int(0, vector.x, 0);
        public static Vector3Int s0YX(this Vector3Int vector) => new Vector3Int(0, vector.y, vector.x);
        public static Vector3Int s0YY(this Vector3Int vector) => new Vector3Int(0, vector.y, vector.y);
        public static Vector3Int s0YZ(this Vector3Int vector) => new Vector3Int(0, vector.y, vector.z);
        public static Vector3Int s0YW(this Vector3Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int s0Y0(this Vector3Int vector) => new Vector3Int(0, vector.y, 0);
        public static Vector3Int s0ZX(this Vector3Int vector) => new Vector3Int(0, vector.z, vector.x);
        public static Vector3Int s0ZY(this Vector3Int vector) => new Vector3Int(0, vector.z, vector.y);
        public static Vector3Int s0ZZ(this Vector3Int vector) => new Vector3Int(0, vector.z, vector.z);
        public static Vector3Int s0ZW(this Vector3Int vector) => new Vector3Int(0, vector.z, 0);
        public static Vector3Int s0Z0(this Vector3Int vector) => new Vector3Int(0, vector.z, 0);
        public static Vector3Int s0WX(this Vector3Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int s0WY(this Vector3Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int s0WZ(this Vector3Int vector) => new Vector3Int(0, 0, vector.z);
        public static Vector3Int s0WW(this Vector3Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s0W0(this Vector3Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s00X(this Vector3Int vector) => new Vector3Int(0, 0, vector.x);
        public static Vector3Int s00Y(this Vector3Int vector) => new Vector3Int(0, 0, vector.y);
        public static Vector3Int s00Z(this Vector3Int vector) => new Vector3Int(0, 0, vector.z);
        public static Vector3Int s00W(this Vector3Int vector) => new Vector3Int(0, 0, 0);
        public static Vector3Int s000(this Vector3Int vector) => new Vector3Int(0, 0, 0);
    }
}