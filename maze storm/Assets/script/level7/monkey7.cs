using UnityEngine;
using System.Collections;

public class monkey7 : MonoBehaviour {
	public float speed = 100f;//英雄速度
	public Vector2 current_position;
	Animator animator;
	public Grid grid = new Grid(14,10);
	public AStar astar;
	public float time = 0;
	public bool finish = false;//是否已经完成
	
	public bool walk = false;//是否已经开始
	private bool findroad = false;//是否找到路径
	private int hasdone; //已经走过的寻路结点
	public background7 bg;//调用脚本background中的地图
	
	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background7)backgd.GetComponent (typeof(background7));
	}

	public void InitGame()//初始化寻路网格
	{
		hasdone = 1;
		astar = new AStar();
		animator = GetComponent<Animator> ();
		for (int i =0; i< 14; i++) {//初始化地图是否可走
			for (int j =0; j< 10; j++) {
				if(bg.level7.map [i, j]!= 0)
					grid.SetWalkbale(i,j,false);
				else
					grid.SetWalkbale(i,j,true);
			}
		}
		grid.SetStartNode (10,6);
		grid.SetEndNode (7,4);
	}

	void FixedUpdate()
	{
		
		if(startscript.click == true && walk == false) {//开始键被按下
			InitGame();
			walk = true;
			if(astar.findPath(grid) == true)
			{
				findroad = true;
				//print(astar._path.Count);
			}
		}
		else if (walk == true && hasdone < astar._path.Count) {
			time += Time.deltaTime;
			Vector2 des;//目的地
			des.x = astar._path[hasdone].x*64 + 32;
			des.y = astar._path[hasdone].y*64 + 50;
			if(WalkTo (des) == true)
			{
				hasdone++;
			}
		}
		if (hasdone >= astar._path.Count) 
		{
			finish = true;
			walk = false;
			startscript.click = false;
			//Destroy(gameObject);
			transform.localScale = new Vector3(0,0,0);
		}
	}
	void TurnRight()//向右转弯的时候打开所有通向右方向的动画和关闭从右出去的动画
	{
		//animator.SetInteger ("etorr", 1);
		animator.SetInteger ("rbtorr", 1);
		animator.SetInteger ("rftorr", 1);
		animator.SetInteger ("rrtorb", 0);
		animator.SetInteger ("rrtorf", 0);
	}
	
	void TurnLeft()
	{
		//animator.SetInteger ("etorl", 1);
		animator.SetInteger ("rbtorl", 1);
		animator.SetInteger ("rftorl", 1);
		animator.SetInteger ("rltorb", 0);
		animator.SetInteger ("rltorf", 0);
	}
	
	void TurnBack()
	{
		//animator.SetInteger ("etorb", 1);
		animator.SetInteger ("rftorb", 1);
		animator.SetInteger ("rrtorb", 1);
		animator.SetInteger ("rltorb", 1);
		animator.SetInteger ("rbtorl", 0);
		animator.SetInteger ("rbtorr", 0);
		animator.SetInteger ("rbtorf", 0);
	}
	
	void TurnFront()
	{
		//animator.SetInteger ("etorf", 1);
		animator.SetInteger ("rbtorf", 1);
		animator.SetInteger ("rrtorf", 1);
		animator.SetInteger ("rltorf", 1);
		animator.SetInteger ("rftorr", 0);
		animator.SetInteger ("rftorl", 0);
		animator.SetInteger ("rftorb", 0);
	}
	
	void GoRight(Vector2 CurPos)
	{
		TurnRight ();
		Vector2 target = Vector2.right*speed+ CurPos;
		transform.position = Vector2.Lerp( CurPos, target, Time.deltaTime );
	}
	void GoLeft(Vector2 CurPos)
	{
		TurnLeft ();
		Vector2 target = -Vector2.right*speed + CurPos;
		transform.position = Vector2.Lerp( CurPos, target, Time.deltaTime );
	}
	void GoBack(Vector2 CurPos)
	{
		TurnBack ();
		Vector2 target = Vector2.up*speed + CurPos;
		transform.position = Vector2.Lerp( CurPos, target, Time.deltaTime );
	}
	void GoFront(Vector2 CurPos)
	{
		TurnFront ();
		Vector2 target = -Vector2.up*speed + CurPos;
		transform.position = Vector2.Lerp( CurPos, target, Time.deltaTime );
	}
	
	bool WalkTo(Vector2 target)//根据目标点调用向哪个方向走
	{
		current_position = transform.position;
		if (current_position.x < target.x && Mathf.Abs(current_position.x - target.x) >5 ) {
			GoRight (current_position);
			return false;
		} 
		else if (current_position.x > target.x && Mathf.Abs(current_position.x - target.x) >5) {
			GoLeft (current_position);
			return false;
		} 
		else if (current_position.y < target.y && Mathf.Abs(current_position.y - target.y) >5) {
			GoBack (current_position);
			return false;
		}
		else if (current_position.y > target.y && Mathf.Abs(current_position.y - target.y) >5) {
			GoFront(current_position);
			return false;
		}
		return true;
	}
}
