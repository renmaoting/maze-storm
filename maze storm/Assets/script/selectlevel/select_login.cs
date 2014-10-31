using UnityEngine;
using System.Collections;

public class select_login : MonoBehaviour {
	void OnMouseDown (){
		StartCoroutine ("LoadScene");
	}
	AsyncOperation asyn;
	IEnumerator LoadScene()//try again
	{
		yield return new WaitForSeconds(1);
		asyn = Application.LoadLevelAsync ("login");
		yield return new WaitForSeconds(1);
	}
}
