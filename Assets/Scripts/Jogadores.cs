using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogadores : MonoBehaviour
{

    //variavel de velocidade
    public float veloplayer;
    
    public bool jogador1;
    public bool raqueteV;

    //altura minima e maxima
    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jogador1 == true)
        {
            MovimentoDoJogador1();
        }

        if (jogador1 == false)
        {
            MovimentoDoJogador2();
        }
    }

    //codigo de movimento do player 1

    public void MovimentoDoJogador1()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));
        
        if (Input.GetKey(KeyCode.W) && raqueteV == true)
        {
            transform.Translate(Vector2.up * veloplayer * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) && raqueteV == true)
        {
            transform.Translate(Vector2.down * veloplayer * Time.deltaTime);
        }

    }

    //codigo de movimento do player 2
    public void MovimentoDoJogador2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        if (Input.GetKey(KeyCode.UpArrow) && raqueteV == true)
        {
            transform.Translate(Vector2.up * veloplayer * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) && raqueteV == true)
        {
            transform.Translate(Vector2.down * veloplayer * Time.deltaTime);
        }
    }
}
