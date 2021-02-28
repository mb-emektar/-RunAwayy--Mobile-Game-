using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class health : MonoBehaviour
{
    public static int remainingHealth = 3;
    public TextMeshProUGUI healthText,finalScore;
    public GameObject finalScene;
    public AudioSource gameOverMusicSource;
    public AudioSource inGameMusicSource;
    public AudioSource outGameMusicSource;
    public AudioClip gameOverMusic;
    public AudioClip outGameMusic;

    private bool soundPlayed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + remainingHealth.ToString();
        if (remainingHealth == 0 && !soundPlayed) {
            
            inGameMusicSource.Stop();
            AudioSource.PlayClipAtPoint(gameOverMusic,new Vector3 (0,0,0),1.0f);
            finalScore.text = "Score: " + lightSibers.score.ToString();
            finalScene.SetActive(true);
            Time.timeScale = 0;
            AudioSource.PlayClipAtPoint(outGameMusic, new Vector3(0, 0, 0), 1.0f);
            soundPlayed = true;

        }
    }

}
