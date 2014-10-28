using UnityEngine;
using System.Collections;

public class rockclick2 : MonoBehaviour {
	public background2 bg;//调用脚本background中的地图
	public hero2 heroscript;//调用脚本background中的地图
	public monkey2 moneyscript;

	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background2)backgd.GetComponent (typeof(background2));

		GameObject heroobj = GameObject.Find ("hero"); //调用脚本background中的地图
		heroscript = (hero2)heroobj.GetComponent (typeof(hero2));
		
		GameObject moneyobj = GameObject.Find ("enemy"); //调用脚本background中的地图
		moneyscript = (monkey2)moneyobj.GetComponent (typeof(monkey2));
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown (){
		if (heroscript.walk == false && heroscript.finish == false && moneyscript.walk == false && moneyscript.finish == false) {
						Vector2 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
						int x = (int)mousepos.x / 64;
						int y = (int)mousepos.y / 64;
						bg.level2.SetMap (x, y, 0);
						bg.avalueblock++;
						Destroy (gameObject);
				}
	}
}
