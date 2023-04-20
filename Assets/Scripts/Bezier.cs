using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Bezier
{

    //public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float t)
    //{
    //    Vector3 p01 = Vector3.Lerp(p0, p1, t);
    //    Vector3 p12 = Vector3.Lerp(p1, p2, t);
    //    Vector3 p23 = Vector3.Lerp(p2, p3, t);
    //    Vector3 p34 = Vector3.Lerp(p3, p4, t);

    //    Vector3 p012 = Vector3.Lerp(p01, p12, t);
    //    Vector3 p123 = Vector3.Lerp(p12, p23, t);
    //    Vector3 p234 = Vector3.Lerp(p23, p34, t);

    //    Vector3 p0123 = Vector3.Lerp(p012, p123, t);
    //    Vector3 p1234 = Vector3.Lerp(p123, p234, t);

    //    Vector3 p01234 = Vector3.Lerp(p0123, p1234, t);

    //    return p01234;
    //}

    public static Vector3 GetPoint(Vector3[] points, float t)
    {
        Vector3[] pointss = points;

        for(int i = 0; i < points.Length - 1; i++)
        {
            pointss = GetVectorPoints(pointss, t);
        }

        return pointss[0];
    }

    private static Vector3[] GetVectorPoints(Vector3[] points, float t)
    {
        Vector3[] pointsOne = new Vector3[points.Length - 1];
        for (int i = 0; i < points.Length - 1; i++)
        {
            pointsOne[i] = Vector3.Lerp(points[i], points[i + 1], t);
        }

        return pointsOne;
    }
}
