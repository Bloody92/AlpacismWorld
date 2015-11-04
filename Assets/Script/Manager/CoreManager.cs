using UnityEngine;
using System.Collections;

public class CoreManager : MonoBehaviour {

	//FUNCION QUE SE EJECUTA ANTES DE CREAR LA ESCENA
	void Awake(){
	
		//DontDestroyOnLoad --> HACE QUE EL OBJETO QUE SE PASA NO SE DESTRUYA ENTRE ESCENAS (EN ESTE CASO ES EL GAMEOBJECT COREMANAGER)
		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start () {
		//CARGO EL SIGUIENTE NIVEL
		Application.LoadLevel (1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
