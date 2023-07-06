using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public Transform puntoDisparo;
    public GameObject disparoPrefab;
    public AudioSource Sonidodisparo;
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            disparar();
            Sonidodisparo.Play();
        }
    }

    void disparar(){
        Instantiate(disparoPrefab, puntoDisparo.position, puntoDisparo.rotation);
    }
}
