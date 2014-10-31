using UnityEngine;
using System.Collections;

public class about : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnClick()
	{
		//Application.LoadLevel ("level1");
		StartCoroutine ("LoadMainScene");
	}

	AsyncOperation asyn;
	IEnumerator LoadMainScene()
	{
		yield return new WaitForSeconds(1);
		asyn = Application.LoadLevelAsync ("about");
		yield return new WaitForSeconds(1);
	}
}
