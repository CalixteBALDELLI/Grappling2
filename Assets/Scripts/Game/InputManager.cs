using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    PlayerMovement playerMovement;
    [SerializeField] Rigidbody playerGM;

    void Update()
    {
        
        if (Mouse.current.leftButton.wasPressedThisFrame &&  ScoringManager.SINGLETON.isMoving == false)
        {
            Debug.Log("holding");
            playerGM.position += new Vector3(5, 0, 0); // Eloigner le j. de la p. par rapport à la longueur du grapping
            ScoringManager.SINGLETON.currentPlayerRotationSpeed = 250;
            ScoringManager.SINGLETON.isRotating = true;

        }

        if (Mouse.current.leftButton.wasReleasedThisFrame &&  ScoringManager.SINGLETON.isMoving == false)
        {
            Debug.Log("released");
            ScoringManager.SINGLETON.isRotating = false;
            ScoringManager.SINGLETON.currentPlayerRotationSpeed = 0;
            ScoringManager.SINGLETON.playerSpeed = 50;
            ScoringManager.SINGLETON.isMoving = true;
        }
    }
}
