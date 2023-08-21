using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class GameManager : MonoBehaviour
{

    //Pontuação
    public int pontosplayer1;
    public int pontosplayer2;

    public Text textoDePontuacao;
    public Text textoDeSetL;
    public Text textoDeSetR;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pontosplayer1 >= 21 || pontosplayer2 >= 21)
        {
            if (pontosplayer1 > pontosplayer2 + 2)
            {
                AumentarSetDoJogador1();
            }

            if (pontosplayer2 > pontosplayer1 + 2)
            {
                AumentarSetDoJogador2();
            }
        }

        if (textoDeSetL.text == "111" || textoDeSetR.text == "111")
        {
                textoDePontuacao.text = "Fim de Jogo!";
        }
    }
    //aumentar pontos
    public void AumentarPontuacaoDoJogador1()
    {
        pontosplayer1 += 1;
        AtualizarTextoDePontuacao();

    }
    public void AumentarPontuacaoDoJogador2()
    {
        pontosplayer2 += 1;
        AtualizarTextoDePontuacao();
    }
    //atualizar pontuação
    public void AtualizarTextoDePontuacao()
    {
        textoDePontuacao.text = pontosplayer1 + " X " + pontosplayer2;
    }
    //pontos set
    public void AumentarSetDoJogador1()
    {
        textoDeSetL.text = textoDeSetL.text + "1";
        pontosplayer1 = 0;
        pontosplayer2 = 0;
        AtualizarTextoDePontuacao();

    }

    public void AumentarSetDoJogador2()
    {
        textoDeSetR.text = textoDeSetR.text + "1";
        pontosplayer1 = 0;
        pontosplayer2 = 0;
        AtualizarTextoDePontuacao();

    }
}
