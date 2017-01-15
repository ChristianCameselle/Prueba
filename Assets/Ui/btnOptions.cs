using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnOptions : MonoBehaviour {

	public Canvas panelOpciones;
	public Button btnCerrar;
	public Button btnModosPantalla;
	

	

	// Use this for initialization
	void Start () {
		panelOpciones = panelOpciones.GetComponent<Canvas>();
		btnCerrar = btnCerrar.GetComponent<Button>();
		btnModosPantalla = btnModosPantalla.GetComponent<Button>();
		panelOpciones.enabled = false;
	}

	public void mostrarPanel(){
		panelOpciones.enabled = true;
	}
	public void cerrarPanel(){
		panelOpciones.enabled = false;
	}
	public void modoPantalla(){
		
		Screen.fullScreen = true;

	}
}
