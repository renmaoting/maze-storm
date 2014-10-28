using UnityEngine;
using System.Collections;

public class rockclick11 : MonoBehaviour {
	public background11 bg;//调用脚本background中的地图
	public hero11 heroscript;//调用脚本background中的地图
	public monkey11 moneyscript;

	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background11)backgd.GetComponent (typeof(background11));

		GameObject heroobj = GameObject.Find ("hero"); //调用脚本background中的地图
		heroscript = (hero11)heroobj.GetComponent (typeof(hero11));
		
		GameObject moneyobj = GameObject.Find ("enemy"); //调用脚本background中的地图
		moneyscript = (monkey11)moneyobj.GetComponent (typeof(monkey11));
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown (){
		if (heroscript.walk == false && heroscript.finish == false && moneyscript.walk == false && moneyscript.finish == false) {
						Vector2 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
						int x = (int)mousepos.x / 64;
						int y = (int)mousepos.y / 64;
						bg.level11.SetMap (x, y, 0);
						bg.avalueblock++;
						Destroy (gameObject);
				}
	}
}
