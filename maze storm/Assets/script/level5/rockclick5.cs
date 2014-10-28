using UnityEngine;
using System.Collections;

public class rockclick5 : MonoBehaviour {
	public background5 bg;//调用脚本background中的地图
	public hero5 heroscript;//调用脚本background中的地图
	public monkey5 moneyscript;

	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background5)backgd.GetComponent (typeof(background5));

		GameObject heroobj = GameObject.Find ("hero"); //调用脚本background中的地图
		heroscript = (hero5)heroobj.GetComponent (typeof(hero5));
		
		GameObject moneyobj = GameObject.Find ("enemy"); //调用脚本background中的地图
		moneyscript = (monkey5)moneyobj.GetComponent (typeof(monkey5));
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown (){
		if (heroscript.walk == false && heroscript.finish == false && moneyscript.walk == false && moneyscript.finish == false) {
						Vector2 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
						int x = (int)mousepos.x / 64;
						int y = (int)mousepos.y / 64;
						bg.level5.SetMap (x, y, 0);
						bg.avalueblock++;
						Destroy (gameObject);
				}
	}
}
