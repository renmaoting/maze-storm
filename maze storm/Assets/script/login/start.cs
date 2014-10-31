using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {
	void OnMouseDown()
	{
		//Application.LoadLevel ("level1");
		StartCoroutine ("LoadMainScene");
	}

	AsyncOperation asyn;
	IEnumerator LoadMainScene()
	{
		yield return new WaitForSeconds(1);
		asyn = Application.LoadLevelAsync ("selectlevel");
		yield return new WaitForSeconds(1);
	}
}
