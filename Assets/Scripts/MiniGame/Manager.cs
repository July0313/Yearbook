using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Button restartBtn, homeBtn;
    public Text scoreTxt, CoinTxt;

    private void Start()
    {
        restartBtn.onClick.AddListener(Restart);
        homeBtn.onClick.AddListener(Home);
    }

    private void OnEnable()
    {
        Cactus.isGame = false;
        Time.timeScale = 0f;

        scoreTxt.text = "SCORE : " + Cactus.score;
        CoinTxt.text = "COIN : " + (Cactus.score / 5);
        DataManager.instance.coin += (Cactus.score / 5);
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
        Cactus.isGame = true;
    }

    public void Restart()
    {
        this.gameObject.SetActive(false);
    }

    public void Home()
    {
        SceneManager.LoadScene("Main");
    }

    /*
    public void restart()
    {
        isGame = true;
        speed = initSpeed;
        score = 0;
        gameObject.transform.position = new Vector3(6.5f, gameObject.transform.position.y, 0);
    }
    */
}
