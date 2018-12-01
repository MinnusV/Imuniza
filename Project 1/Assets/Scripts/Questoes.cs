using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Questoes : MonoBehaviour {

    public Text r1,r2,r3;
    public Text pergunta;
    //public Text just, pontos;

    //public GameObject painel;

    //protected int i = 0;
    //protected int p = 0;

    private void Start()
    {

        QuestoesData.AddQuestao();

        ProxPergunta(UserData.numQuestao);
        
    }

    public void ProxPergunta(int indice)
    {
        //painel.SetActive(false);
        if (indice < QuestoesData.mPerguntas.Length)
        {
            pergunta.text = QuestoesData.mPerguntas[indice][0];
            r1.text = QuestoesData.mPerguntas[indice][1];
            r2.text = QuestoesData.mPerguntas[indice][4];
            r3.text = QuestoesData.mPerguntas[indice][7];

        }
        UserData.numQuestao++;
    }

    public void SalvaTxtJustificativa(Text resposta)
    {
        QuestoesData.respAux = resposta.text;

        SceneManager.LoadScene("Justificativa");
    }

    //ChamaJustificativa old
    /*
    public void ChamaJustificativa(Text txtResp)
    {
        painel.SetActive(true);
        if (txtResp.text.Equals(QuestoesData.mPerguntas[i - 1][1]))
        {
            just.text = QuestoesData.mPerguntas[i - 1][2];
            pontos.text = "+" + ContarPontos(QuestoesData.mPerguntas[i - 1][3]);
        }
        else if (txtResp.text.Equals(QuestoesData.mPerguntas[i - 1][4])) 
        {
            just.text = QuestoesData.mPerguntas[i - 1][5];
            pontos.text = "+" + ContarPontos(QuestoesData.mPerguntas[i - 1][6]);
        }
        else if (txtResp.text.Equals(QuestoesData.mPerguntas[i - 1][7]))
        {
            just.text = QuestoesData.mPerguntas[i - 1][8];
            pontos.text = "+" + ContarPontos(QuestoesData.mPerguntas[i - 1][9]);
        }
    }
    */

    //ContarPontos old
    /*
    public string ContarPontos(string valor)
    {
        if (valor.Equals("30"))
        {
            p += 30 + UserData.userTime;
            return (30 + UserData.userTime).ToString();
        }
        else if (valor.Equals("10"))
        {
            p += 10 + UserData.userTime;
            return (10 + UserData.userTime).ToString();
        }
        else if (valor.Equals("0"))
        {
            p += 0;
            return "0";
        }
        else
        {
            return string.Empty;
        }
    }
    */

    private void Update()
    {
        if(UserData.numQuestao == QuestoesData.mPerguntas.Length+1)
        {
            UserData.numQuestao = 0;

            SceneManager.LoadScene("EndGame");
        }
    }

}
