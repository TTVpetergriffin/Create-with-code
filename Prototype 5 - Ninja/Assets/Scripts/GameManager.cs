using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button restartButton;
    public bool isGameActive;
    public TextMeshProUGUI gameOverText;
    private int score;
    public TextMeshProUGUI scoreText;
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
    
    }
    public void StartGame()
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
