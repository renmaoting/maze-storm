using UnityEngine;
using System.Collections;

public class rockclick13 : MonoBehaviour {
	public background13 bg;//调用脚本background中的地图
	public hero13 heroscript;//调用脚本background中的地图
	public monkey13 moneyscript;

	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background13)backgd.GetComponent (typeof(background13));

		GameObject heroobj = GameObject.Find ("hero"); //调用脚本background中的地图
		heroscript = (hero13)heroobj.GetComponent (typeof(hero13));
		
		GameObject moneyobj = GameObject.Find ("enemy"); //调用脚本background中的地图
		moneyscript = (monkey13)moneyobj.GetComponent (typeof(monkey13));
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown (){
		if (heroscript.walk == false && heroscript.finish == false && moneyscript.walk == false && moneyscript.finish == false) {
						Vector2 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
						int x = (int)mousepos.x / 64;
						int y = (int)mousepos.y / 64;
						bg.level13.SetMap (x, y, 0);
						bg.avalueblock++;
						Destroy (gameObject);
				}
	}
}
