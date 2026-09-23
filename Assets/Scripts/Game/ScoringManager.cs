using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoringManager : MonoBehaviour
{
    public int CurrentScore;
    
    private static ScoringManager instance = null;
    public static ScoringManager SINGLETON => instance;
    public float playerSpeed;
    public float currentPlayerRotationSpeed;
    public GameObject currentPlatform;
    public bool isRotating;
    public bool isMoving;
    public Canvas gameOverCanvas;


    public TextMeshProUGUI scoreText;
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        //DontDestroyOnLoad(this.gameObject);
        }

    public void IncreaseScore(int amount)
    {
        CurrentScore += amount;
        scoreText.text = CurrentScore.ToString();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverCanvas.enabled = true;
    }
    
    public void Restart()
    {
        CurrentScore = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
