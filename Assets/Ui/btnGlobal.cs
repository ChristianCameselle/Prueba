using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class btnGlobal : MonoBehaviour {

	public Button txtNewGame;
	public Button txtContinue;
	public Button txtOptions;
	public Button txtExit;

	void Start () {
		
	}

	public void CambiarMain(){
		SceneManager.LoadScene("Main");
	}
    public void CambiarCity(){
		SceneManager.LoadScene("House");
	}
    
}
