using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public void GoLevel(int level){
		Application.LoadLevel (level);
	}


}
