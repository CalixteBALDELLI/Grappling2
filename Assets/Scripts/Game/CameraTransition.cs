using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using Vector3 = UnityEngine.Vector3;

public class CameraTransition : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 newPosition;

    private void Start()
    {
        newPosition = transform.position;
    }

    void FixedUpdate()
    {
        {
            target = ScoringManager.SINGLETON.currentPlatform.transform;
            newPosition.x = Mathf.Lerp(transform.position.x, target.position.x + 5, 0.025f);
            newPosition.z = Mathf.Lerp(transform.position.z, target.position.z, 0.025f);
            transform.position = newPosition;
        }
    }
}
