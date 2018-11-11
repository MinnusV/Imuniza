using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Questoes : MonoBehaviour {
    
    public Text r1;
    public Text r2;
    public Text r3;
    public Text pergunta;

    protected int i = 1;
    protected int p = 0;
    

    private void Start()
    {

        QuestoesData.AddQuestao();

        pergunta.text = QuestoesData.mPerguntas[0][0];
        r1.text = QuestoesData.mPerguntas[0][1];
        r2.text = QuestoesData.mPerguntas[0][4];
        r3.text = QuestoesData.mPerguntas[0][7];


    }

    public void ProxPergunta()
    {
        if (i < QuestoesData.mPerguntas.Length)
        {
            pergunta.text = QuestoesData.mPerguntas[i][0];
            r1.text = QuestoesData.mPerguntas[i][1];
            r2.text = QuestoesData.mPerguntas[i][4];
            r3.text = QuestoesData.mPerguntas[i][7];
        }
        i++;
    }

    public void ContarPontos(int valor)
    {
        p += valor + UserData.userTime;
    }

    private void Update()
    {
        if(i == QuestoesData.mPerguntas.Length+1)
        {
            UserData.userPontos = p;

            SceneManager.LoadScene("EndGame");
        }
    }

}
