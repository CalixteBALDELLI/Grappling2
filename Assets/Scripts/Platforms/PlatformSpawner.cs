using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] platforms;
    int platformToSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        platformToSpawn = Random.Range(0, 3);
        Instantiate(platforms[platformToSpawn], gameObject.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
