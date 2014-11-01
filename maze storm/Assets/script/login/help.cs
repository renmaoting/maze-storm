using UnityEngine;
using System.Collections;

public class help : MonoBehaviour {

	void OnMouseDown()
	{
		//Application.LoadLevel ("level1");
		StartCoroutine ("LoadMainScene");
	}
	
	AsyncOperation asyn;
	IEnumerator LoadMainScene()
	{
		yield return new WaitForSeconds(1);
		asyn = Application.LoadLevelAsync ("help");
		yield return new WaitForSeconds(1);
	}
}
