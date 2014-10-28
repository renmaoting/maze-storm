using UnityEngine;
using System.Collections;

public class rockclick : MonoBehaviour {
	public background bg;//调用脚本background中的地图
	public hero heroscript;//调用脚本background中的地图
	public money moneyscript;

	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background)backgd.GetComponent (typeof(background));

		GameObject heroobj = GameObject.Find ("hero"); //调用脚本background中的地图
		heroscript = (hero)heroobj.GetComponent (typeof(hero));
		
		GameObject moneyobj = GameObject.Find ("enemy"); //调用脚本background中的地图
		moneyscript = (money)moneyobj.GetComponent (typeof(money));
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown (){
		if (heroscript.walk == false && heroscript.finish == false && moneyscript.walk == false && moneyscript.finish == false) {
			Vector2 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			int x = (int)mousepos.x / 64;
			int y = (int)mousepos.y / 64;
			bg.level1.SetMap (x, y, 0);
			bg.avalueblock++;
			Destroy (gameObject);
		}
	}
}
