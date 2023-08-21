using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    //variavel da velocidade da bola
    public float velobola;

    public Rigidbody2D oRigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        //codigo da bola
        oRigidbody2D.velocity = new Vector2(velobola, velobola) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
