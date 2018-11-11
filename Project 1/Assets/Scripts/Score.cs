using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    
    public Text pontosTxt;
    public Slider sliderPontos;

    private int aux;
    

	// Use this for initialization
	void Start () {
        sliderPontos.value = 0;

        pontosTxt.text = UserData.userPontos.ToString("D");
        aux = UserData.userPontos;
	}
	
	// Update is called once per frame
	void Update () {
		if(aux != sliderPontos.value)
        {
            sliderPontos.value++;
        }
	}
}
