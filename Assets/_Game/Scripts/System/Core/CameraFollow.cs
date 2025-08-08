using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Range(0, 1)] [SerializeField] float _smoothTime = 0.45f;
    [Space]
    [SerializeField] Transform _target;

    float _offsetZ;
    bool _stopFollowing = false;

    Vector3 _currentVelocity;

    private void Start()
    {
        _offsetZ = transform.position.z - _target.transform.position.z;
    }

    private void LateUpdate()
    {
        if (_stopFollowing) return;

        FollowTarget();
    }

    private void FollowTarget()
    {
        Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y, _target.position.z + _offsetZ);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, _smoothTime); ;
    }
}
