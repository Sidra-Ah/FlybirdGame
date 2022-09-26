using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playerController : MonoBehaviour
{
    public float Force;
    private Rigidbody2D rb;
    private Animator animtn;
    private int Points = 0;
    // public Text Score;
    public TextMeshPro Score;
    private int Coins = 0;
    public TextMeshPro gainCoin;
    public AudioSource coinplay;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animtn = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
    {
        ClickedOnMouse();
        // GetComponent<Rigidbody2D>().velocity = Vector2.up*Force;
    }
    else{
        animtn.SetBool("clicked", false);
    }
    }

    void ClickedOnMouse()
    {
        rb.velocity = Vector2.up * Force;
        animtn.SetBool("clicked", true);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("GameOver");
        PlayerPrefs.SetInt("highScore",Points);

        
    }

   private void OnTriggerEnter2D(Collider2D collusion) {
        if(collusion.gameObject.tag == "PipeScore")
        {
            Points++;
            Score.text = Points.ToString("00");
        }

        else if(collusion.gameObject.tag == "coins")
        {
            coinplay = GetComponent<AudioSource>();
            coinplay.clip = Resources.Load<AudioClip>("coin");
            coinplay.Play();
            Coins++;
            gainCoin.text = Coins.ToString();
            // Debug.Log("you got coin");
            Destroy(collusion.gameObject);
        }
    }
  
}
