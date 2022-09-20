using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour
{
public AudioSource sound;
public AudioSource click;



 public void PlayGame(){
   click = GetComponent<AudioSource>();
   click.clip = Resources.Load<AudioClip>("click");
   click.Play();
    SceneManager.LoadScene("HardLevel");
   
    // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }
  public void EasyLevel(){
   click = GetComponent<AudioSource>();
   click.clip = Resources.Load<AudioClip>("click");
   click.Play();
    SceneManager.LoadScene("EasyLevel");
   
    // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }
 public void Credits(){
    SceneManager.LoadScene("");
  
 }

 public void Quit(){
   click = GetComponent<AudioSource>();
   click.clip = Resources.Load<AudioClip>("click");
   click.Play();
    Application.Quit();
    Debug.Log("Quit Game");
  
 }
}
