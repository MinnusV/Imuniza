using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Justificativa : MonoBehaviour {

    public GameObject btnProx;

    private float tempoAtual = 0;

	// Use this for initialization
	private void Start () {

	}
	
	// Update is called once per frame
	private void Update () {
        
        tempoAtual += Time.deltaTime;

        if(tempoAtual >= 3.0)
        {
            btnProx.SetActive(true);
        }
        
	}

}
