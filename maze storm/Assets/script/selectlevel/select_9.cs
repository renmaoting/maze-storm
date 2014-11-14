using UnityEngine;
using System.Collections;

public class select_9 : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown (){
		if (PlayerPrefs.GetInt("LEVEL") >= 9) 
		{
			StartCoroutine ("LoadScene");
		}
	}
	AsyncOperation asyn;
	IEnumerator LoadScene()//try again
	{
		yield return new WaitForSeconds(1);
		asyn = Application.LoadLevelAsync ("level12");
		yield return new WaitForSeconds(1);
	}
}
