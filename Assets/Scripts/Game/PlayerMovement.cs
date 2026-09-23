using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    

    private void FixedUpdate()
    {
        if (ScoringManager.SINGLETON.isRotating)
        {
            transform.RotateAround(ScoringManager.SINGLETON.currentPlatform.transform.position, new Vector3(0, 1, 0), ScoringManager.SINGLETON.currentPlayerRotationSpeed * Time.deltaTime);
        }

        if (ScoringManager.SINGLETON.isMoving)
        {
            rb.MovePosition(transform.position += transform.rotation * new Vector3(1, 0, 0) * ScoringManager.SINGLETON.playerSpeed * Time.deltaTime);
        }
    }

    private void OnBecameInvisible()
    {
        ScoringManager.SINGLETON.GameOver();
    }
}
