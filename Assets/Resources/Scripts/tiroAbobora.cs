﻿using UnityEngine;
using System.Collections;

public class tiroAbobora : MonoBehaviour 
{
    
    public static float velocidadeTiro;
    float SentidoDoTiroV = Input.GetAxisRaw("P1_Vertical");
    float SentidoDoTiroH = Input.GetAxisRaw("P1_Horizontal");
     
	void Start () 
    {
        
        velocidadeTiro = 5f;
	}

	void Update () 
    {

        if (SentidoDoTiroH > 0) {
            this.transform.Translate(Vector2.right * velocidadeTiro * Time.deltaTime);
        }
        if (SentidoDoTiroH < 0) {
            this.transform.Translate(-Vector2.right * velocidadeTiro * Time.deltaTime);
        }
        if (SentidoDoTiroV > 0)
        {
            this.transform.Translate(Vector2.up * velocidadeTiro * Time.deltaTime);
        }
        if (SentidoDoTiroV < 0)
        {
            this.transform.Translate(-Vector2.up * velocidadeTiro * Time.deltaTime);
        }
         
    }
        
    /// <summary>
    /// Destroi objetos quando não estão visiveis
    /// </summary>
    void OnBecameInvisible() {

        Destroy(this.gameObject);
    }
     
}
