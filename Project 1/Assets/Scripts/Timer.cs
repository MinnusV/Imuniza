using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Slider time;
    public Image fill;

    private float tempoAtual = 0.0f;
    private int t = 0;

    // Use this for initialization
    private void Start () {
        tempoAtual = 31;
        fill.color = Color.green;
	}
	
	// Update is called once per frame
	private void Update () {
        tempoAtual -= Time.deltaTime;

        if (tempoAtual > 0.0)
        {
            time.value = tempoAtual;
            t = (int)tempoAtual;

        }else if(tempoAtual < 1.0)
        {
            SceneManager.LoadScene("EndGame");
        }

        if((tempoAtual < 20) && (tempoAtual > 10))
        {
            fill.color = Color.yellow;
        }
        else if(tempoAtual < 10)
        {
            fill.color = Color.red;
        }
	}

    public void GuardarTempo()
    {
        UserData.userTime = t;
        tempoAtual = 31;
        
    }
}
