﻿using UnityEngine;
using System.Collections;

public class tryagain10 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown (){
		StartCoroutine ("LoadCurrentScene");
	}
	AsyncOperation asyn;
	IEnumerator LoadCurrentScene()//try again
	{
		yield return new WaitForSeconds(1);
		//asyn = Application.LoadLevelAsync ("level3");
		asyn = Application.LoadLevelAsync ("level10");
		yield return new WaitForSeconds(1);
	}
}