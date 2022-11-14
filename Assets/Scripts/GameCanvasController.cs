using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameCanvasController : MonoBehaviour
{
    public static GameCanvasController instance;
    public GameObject loseGame;
    public Image sliderFill;
    public Button tryAgainButton;
    public Button backToMenuButton;
    public TextMeshProUGUI pointsText;

    // Update is called once per frame
    void Awake(){
        instance = this;
        StartGame();
        tryAgainButton.onClick.AddListener(TryAgain);
        backToMenuButton.onClick.AddListener(BackToMenu);
    }
    public void AddPoints(int points){
        pointsText.text = "Pontos: " + points*100;
    }
    private void TryAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void BackToMenu(){
        SceneManager.LoadScene(0);
    }
    public void LoseGame(){
        loseGame.SetActive(true);
        Time.timeScale = 0.0f;
    }
    private void StartGame(){
        loseGame.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
