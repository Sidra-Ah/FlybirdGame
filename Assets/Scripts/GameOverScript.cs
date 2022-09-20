using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
   
    public Text Points;
    private Animator ani;
    public AudioSource click;
    
    // Start is called before the first frame update
    void Start()
    {
       Points.text = "Score" + " : " + PlayerPrefs.GetInt("highScore");
       ani = GetComponent<Animator>();
    
    }

    // Update is called once per frame
    public void playAgain()
    {
        SceneManager.LoadScene("GameScene");
        click = GetComponent<AudioSource>();
        click.clip = Resources.Load<AudioClip>("click");
        click.Play();

    }
}
