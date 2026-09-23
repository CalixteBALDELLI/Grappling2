using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform platform ;
    [SerializeField] float speed;

    void OnTriggerEnter(Collider other)
    {
        ScoringManager.SINGLETON.GameOver();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAround(platform.position, new Vector3(0, 1, 0), speed * Time.deltaTime);

    }
}
