using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierTest : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private GameObject _gameObject;

    private Vector3[] _pointsVector;

    [Range(0, 1)] private float t;

    private void OnDrawGizmosSelected()
    {
        int sigmentNumber = 20;
        Vector3 prevousePoint = _pointsVector[0];
        Gizmos.color = Color.red;

        for (int i = 0; i <= sigmentNumber; i++)
        {
            float paremeter = (float)i / sigmentNumber;
            Vector3 point = Bezier.GetPoint(_pointsVector, paremeter);
            Gizmos.DrawLine(prevousePoint, point);
            prevousePoint = point;
        }
    }

    private void Awake()
    {
        _pointsVector = GetPoints();
    }

    private void Update()
    {
        _pointsVector = GetPoints();
        _gameObject.transform.position = Bezier.GetPoint(_pointsVector, t);
    }

    private Vector3[] GetPoints()
    {
        Vector3[] points = new Vector3[_points.Length];

        for (int i = 0; i < points.Length; i++)
        {
            points[i] = _points[i].position;
        }

        return points;
    }
}
