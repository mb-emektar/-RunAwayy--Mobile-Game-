using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class lightSibers : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;
    AudioSource scoreAudioSource;
    public AudioClip scoreSound;
    AudioSource hitAudioSource;
    public AudioClip hitSound;

    public int speed;

    void Start()
    {
        scoreAudioSource = scoreText.GetComponent<AudioSource>();
        hitAudioSource = gameObject.GetComponent<AudioSource>(); 

    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0,90* Time.deltaTime* speed));

        
    }

    void OnCollisionEnter2D(Collision2D touch) 
    {
        float xPosition = Random.Range(-2.5f, 2.5f);
        float yPosition = Random.Range(6f, 10f);

        if (touch.gameObject.tag == "ControlStick")
            transform.position = new Vector2(xPosition, yPosition);
        else if (touch.gameObject.tag == "Player")
        {
            transform.position = new Vector2(xPosition, yPosition);
            scoreAudioSource.PlayOneShot(hitSound, 0.4F);
            health.remainingHealth--;
        }
    }
    void OnTriggerEnter2D(Collider2D touch)
    {
        if (touch.gameObject.tag == "ScoreStick")
        {
            scoreAudioSource.PlayOneShot(scoreSound, 0.4F);
            score += 1;
            scoreText.text = score.ToString();
        }

    }

    }
