using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D enemyRb;
    public float speed;
    public int score = 50;
    public Text ScoreText;
    ScoreManager scoreManager;

    public AudioClip playerClip;
    AudioSource playerAudio;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        scoreManager = FindObjectOfType<ScoreManager>();
        playerAudio = GameObject.Find("AudioManager").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("EndScene");
        }
        else if(collision.gameObject.tag == "Ground")
        {
            scoreManager.IncrementScore();
            playerAudio.clip = playerClip;
            playerAudio.Play();
            //print("ground");
        }
    }
}