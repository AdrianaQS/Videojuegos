using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Final : MonoBehaviour
{public AudioSource portal;
  private void OnTriggerEnter2D(Collider2D colision){
    if (colision.gameObject.name == "player"){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        portal.Play();
    }

  }
}
