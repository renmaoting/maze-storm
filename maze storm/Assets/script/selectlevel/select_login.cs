﻿using UnityEngine;
using System.Collections;

public class select_login : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
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
