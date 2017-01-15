using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class btnCambioEscena : MonoBehaviour {

	public Button MainDoor;
	public void MoverHall(){
		SceneManager.LoadScene("House_Hall");
	}

}
