using UnityEngine;
using System.Collections;

public class rockclick2 : MonoBehaviour {
	public background2 bg;//调用脚本background中的地图

	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background2)backgd.GetComponent (typeof(background2));
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown (){
		Vector2 mousepos =  Camera.main.ScreenToWorldPoint (Input.mousePosition);
		int x = (int)mousepos.x / 64;
		int y = (int)mousepos.y / 64;
		bg.level2.SetMap (x,y,0);
		bg.avalueblock++;
		Destroy(gameObject);
	}
}
