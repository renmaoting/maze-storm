using UnityEngine;
using System.Collections;

public class rockclick8 : MonoBehaviour {
	public background8 bg;//调用脚本background中的地图
	public hero8 heroscript;//调用脚本background中的地图
	public monkey8 moneyscript;

	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background8)backgd.GetComponent (typeof(background8));

		GameObject heroobj = GameObject.Find ("hero"); //调用脚本background中的地图
		heroscript = (hero8)heroobj.GetComponent (typeof(hero8));
		
		GameObject moneyobj = GameObject.Find ("enemy"); //调用脚本background中的地图
		moneyscript = (monkey8)moneyobj.GetComponent (typeof(monkey8));
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown (){
		if (heroscript.walk == false && heroscript.finish == false && moneyscript.walk == false && moneyscript.finish == false) {
						Vector2 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
						int x = (int)mousepos.x / 64;
						int y = (int)mousepos.y / 64;
						bg.level8.SetMap (x, y, 0);
						bg.avalueblock++;
						Destroy (gameObject);
				}
	}
}
