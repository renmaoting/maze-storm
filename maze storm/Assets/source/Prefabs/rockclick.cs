using UnityEngine;
using System.Collections;

public class rockclick : MonoBehaviour {
	public background bg;//调用脚本background中的地图

	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background)backgd.GetComponent (typeof(background));
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown (){
		Destroy(gameObject);
		Vector2 mousepos =  Camera.main.ScreenToWorldPoint (Input.mousePosition);
		int x = (int)mousepos.x / 64;
		int y = (int)mousepos.y / 64;
		bg.level1.SetMap (x,y,0);
	}
}
