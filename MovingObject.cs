using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour
{
    #region Public Attributes
    public GameObject _WayPoints;
    public float _Speed;
    #endregion

    #region Protected Attributes
    #endregion

    #region Private Attributes
    private int _IndexWayPoint;
    #endregion

    void Start()
    {
        _IndexWayPoint = 0;
        Transform destination = _WayPoints.transform.GetChild(_IndexWayPoint++);
        transform.position = destination.position;
        transform.eulerAngles = destination.eulerAngles;
    }

    void FixedUpdate()
    {
        Transform destination = _WayPoints.transform.GetChild(_IndexWayPoint);
        Vector3 diff = destination.position - transform.position;
        float distance = diff.magnitude;
        if (distance < _Speed * 2.0f)
        {
            if (_IndexWayPoint + 1 < _WayPoints.transform.childCount)
                ++_IndexWayPoint;
        }
        else
        {
            transform.position += diff.normalized * _Speed;
        }
    }
}
