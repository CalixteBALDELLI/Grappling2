using System;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class BasePlatform : MonoBehaviour
{
    [SerializeField] private GameObject SpawnerGO;
    [SerializeField] private Transform center;
    [SerializeField] private Rigidbody playerRB;
    private BoxCollider col;
    private int numberToSpawn;
    private void OnTriggerEnter(Collider other)
    {
        playerRB = other.GetComponent<Rigidbody>();
        ScoringManager.SINGLETON.isMoving = false;
        ScoringManager.SINGLETON.playerSpeed = 0;
        playerRB.position = center.position;
        playerRB.rotation = Quaternion.identity;
        ScoringManager.SINGLETON.IncreaseScore(1);
        numberToSpawn = Random.Range(1, 3);
        if (numberToSpawn == 1)
        {
            Instantiate(SpawnerGO, gameObject.transform.position + new Vector3(7, 0, 0), Quaternion.identity);
        }
        if (numberToSpawn == 2)
        {
            Instantiate(SpawnerGO, gameObject.transform.position + new Vector3(7, 0, 7), Quaternion.identity);
            Instantiate(SpawnerGO, gameObject.transform.position + new Vector3(7, 0, -7), Quaternion.identity);
        }
        ScoringManager.SINGLETON.currentPlatform = gameObject;
    }
}
