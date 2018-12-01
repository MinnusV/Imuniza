using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Justificativa : MonoBehaviour {

    public GameObject btnProx;
    public Text just, pontos;

    //protected int i = 0;
    
    private float tempoAtual;

	// Use this for initialization
	private void Start () {
        tempoAtual = 0;

        ChamaJustificativa(QuestoesData.respAux, UserData.numQuestao-1);
	}
	
	// Update is called once per frame
	private void Update () {
        
        tempoAtual += Time.deltaTime;

        if(tempoAtual >= 3.0)
        {
            btnProx.SetActive(true);
        }
        
	}

    public void ChamaJustificativa(string txtResp, int indice)
    {
        if (txtResp.Equals(QuestoesData.mPerguntas[indice][1]))
        {
            just.text = QuestoesData.mPerguntas[indice][2];
            pontos.text = "+" + UserData.ContarPontos(QuestoesData.mPerguntas[indice][3]);
            //i++;
        }
        else if (txtResp.Equals(QuestoesData.mPerguntas[indice][4]))
        {
            just.text = QuestoesData.mPerguntas[indice][5];
            pontos.text = "+" + UserData.ContarPontos(QuestoesData.mPerguntas[indice][6]);
            //i++;
        }
        else if (txtResp.Equals(QuestoesData.mPerguntas[indice][7]))
        {
            just.text = QuestoesData.mPerguntas[indice][8];
            pontos.text = "+" + UserData.ContarPontos(QuestoesData.mPerguntas[indice][9]);
            //i++;
        }

    }

}
