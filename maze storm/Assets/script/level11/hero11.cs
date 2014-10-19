using UnityEngine;
using System.Collections;

public class hero11 : MonoBehaviour {
	public float hero_speed = 100f;//英雄速度
	public Vector2 current_position;
	Animator animator;
	public Grid grid = new Grid(14,10);
	public AStar astar;
	public float time = 0;//总共所用时间
	public bool finish = false;//是否已经完成

	public bool walk = false;//是否已经开始
	private bool findroad = false;//是否找到路径
	private int hasdone; //已经走过的寻路结点
	public background11 bg;//调用脚本background中的地图
	public startscript stspt;//开始脚本

	public monkey11 monkeyscript;
	
	// Use this for initialization
	void Start () {
		GameObject backgd = GameObject.Find ("background"); //调用脚本background中的地图
		bg = (background11)backgd.GetComponent (typeof(background11));

		GameObject moneyobj = GameObject.Find ("enemy"); //调用脚本background中的地图
		monkeyscript = (monkey11)moneyobj.GetComponent (typeof(monkey11));
	}
	public void InitGame()//初始化寻路网格
	{
		hasdone = 1;
		astar = new AStar();
		animator = GetComponent<Animator> ();
		for (int i =0; i< 14; i++) {//初始化地图是否可走
			for (int j =0; j< 10; j++) {
				if(bg.level11.map [i, j]!= 0)
					grid.SetWalkbale(i,j,false);
				else
					grid.SetWalkbale(i,j,true);
			}
		}
		grid.SetStartNode (6,8);
		grid.SetEndNode (6,0);
	}

	void FixedUpdate()
	{
		if(startscript.click == true && walk == false)
		//if (Input.GetButton ("Jump"))
		{//开始键被按下
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
			//print(astar._path[hasdone].x + " " + astar._path[hasdone].y);
			if(WalkTo (des) == true)
			{
				hasdone++;
			}
		}
		if (hasdone >= astar._path.Count) 
		{
			if(finish == false)
				bg.sco+= bg.level*100;
			finish = true;
			walk = false;
			transform.localScale = new Vector3(0,0,0);
			startscript.click = false;
			//Destroy(gameObject);
		}
	}
	void TurnRight()//向右转弯的时候打开所有通向右方向的动画和关闭从右出去的动画
	{
		animator.SetInteger ("sftorr", 1);
		animator.SetInteger ("srtorr", 1);
		animator.SetInteger ("rbtorr", 1);
		animator.SetInteger ("rftorr", 1);
		animator.SetInteger ("rrtorb", 0);
		animator.SetInteger ("rrtorf", 0);
	}

	void TurnLeft()
	{
		animator.SetInteger ("sftorl", 1);
		animator.SetInteger ("sltorl", 1);
		animator.SetInteger ("rbtorl", 1);
		animator.SetInteger ("rftorl", 1);
		animator.SetInteger ("rltorb", 0);
		animator.SetInteger ("rltorf", 0);
	}

	void TurnBack()
	{
		animator.SetInteger ("sftorb", 1);
		animator.SetInteger ("sbtorb", 1);
		animator.SetInteger ("rrtorb", 1);
		animator.SetInteger ("rltorb", 1);
		animator.SetInteger ("rbtorl", 0);
		animator.SetInteger ("rbtorr", 0);
	}

	void TurnFront()
	{
		animator.SetInteger ("sftorf", 1);
		animator.SetInteger ("rrtorf", 1);
		animator.SetInteger ("rltorf", 1);
		animator.SetInteger ("rftorr", 0);
		animator.SetInteger ("rftorl", 0);
	}

	void GoRight(Vector2 CurPos)
	{
		TurnRight ();
		Vector2 target = Vector2.right*hero_speed+ CurPos;
		transform.position = Vector2.Lerp( CurPos, target, Time.deltaTime );
	}
	void GoLeft(Vector2 CurPos)
	{
		TurnLeft ();
		Vector2 target = -Vector2.right*hero_speed + CurPos;
		transform.position = Vector2.Lerp( CurPos, target, Time.deltaTime );
	}
	void GoBack(Vector2 CurPos)
	{
		TurnBack ();
		Vector2 target = Vector2.up*hero_speed + CurPos;
		transform.position = Vector2.Lerp( CurPos, target, Time.deltaTime );
	}
	void GoFront(Vector2 CurPos)
	{
		TurnFront ();
		Vector2 target = -Vector2.up*hero_speed + CurPos;
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
