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
    public void MainMenu()
    {
        SceneManager.LoadScene("mainmenu");
        click = GetComponent<AudioSource>();
        click.clip = Resources.Load<AudioClip>("click");
        click.Play();

    }

    public void Quit(){
        click = GetComponent<AudioSource>();
        click.clip = Resources.Load<AudioClip>("click");
        click.Play();
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
