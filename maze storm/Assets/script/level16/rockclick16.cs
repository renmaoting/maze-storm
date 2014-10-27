﻿using UnityEngine;
using System.Collections;

public class rockclick16 : MonoBehaviour {
	public background16 bg;//调用脚本background中的地图

	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background16)backgd.GetComponent (typeof(background16));
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown (){
		Vector2 mousepos =  Camera.main.ScreenToWorldPoint (Input.mousePosition);
		int x = (int)mousepos.x / 64;
		int y = (int)mousepos.y / 64;
		bg.level16.SetMap (x,y,0);
		bg.avalueblock++;
		Destroy(gameObject);
	}
}
