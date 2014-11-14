﻿using UnityEngine;
using System.Collections;
using System;

public class background8 : MonoBehaviour {
	private int level = 8;//本关是第一关,每次必须初始化
	public int avalueblock = 4;//可用的障碍物的块数
	public int sco = 0;//到达本关的分数 

	// Use this for initialization

	private Vector2 mousepos;
	private Vector2 vec;//鼠标的世界坐标
	private Vector2 vec_screen;//转换成屏幕坐标
	public int x;//将鼠标的世界坐标转换成地图的分区坐标
	public int y;
	public Texture2D image1;//跟随鼠标的图片
	public Texture2D nextImage;//
	public Texture2D againImage;//
	public Texture2D mainImage;//
	public GameObject rock;//要放下的障碍物
	public GameObject grass;//要放下的障碍物
	public GameObject tree;//要放下的障碍物
	public LevelMap8 level8 = new LevelMap8();
	public hero8 heroscript;//调用脚本background中的地图
	public monkey8 moneyscript;
	public startscript stspt;//开始脚本
	private MusicPlayer mup;
	GUIStyle bb;
	GUIStyle aa;


	void Awake () {
		for (int i =1; i< level; i++) {
			sco= sco+ i*100;
		}

		bb = new GUIStyle();
		bb.normal.background = null;    //这是设置背景填充的
		bb.normal.textColor=new Color(1,0,0);   //设置字体颜色的
		bb.fontSize = 50;       //当然，这是字体颜色

		aa = new GUIStyle();
		aa.normal.background = null;    //这是设置背景填充的
		aa.normal.textColor=new Color(1,0,0);   //设置字体颜色的
		aa.fontSize = 30;       //当然，这是字体颜色


		level8.Initial ();
		InitBgSrc ();//动态加载物体
		GameObject heroobj = GameObject.Find ("hero"); //调用脚本background中的地图
		heroscript = (hero8)heroobj.GetComponent (typeof(hero8));

		GameObject moneyobj = GameObject.Find ("enemy"); //调用脚本background中的地图
		moneyscript = (monkey8)moneyobj.GetComponent (typeof(monkey8));

		GameObject startspt = GameObject.Find ("startbtn"); //调用脚本background中的地图
		stspt = (startscript)startspt.GetComponent (typeof(startscript));
	}
	void InitBgSrc()//动态添加物体
	{
		for (int i =0; i< 14; i++) {//初始化地图是否可走
			for (int j =0; j< 10; j++) {
				if(level8.map [i, j]== 1)
				{
					GameObject down = Instantiate(grass,new Vector2(i*64+32,j*64+32),Quaternion.Euler(new Vector3(0,0,0))) as GameObject;
				}
				else if(level8.map [i, j]== 2)
				{
					GameObject down = Instantiate(tree,new Vector2(i*64+32,j*64+32),Quaternion.Euler(new Vector3(0,0,0))) as GameObject;
				}
				else if(level8.map [i, j]== 3)
				{
					GameObject down = Instantiate(rock,new Vector2(i*64+32,j*64+32),Quaternion.Euler(new Vector3(0,0,0))) as GameObject;
				}
			}
		}
	}
	void OnGUI()
	{
		GameObject infoobj = GameObject.Find ("info"); //调用脚本info中的地图
		Vector2 infopos =  infoobj.transform.position;
		Vector2 container = Camera.main.WorldToScreenPoint(new Vector2(infopos.x,0));//以容器参照物
		GUI.Label(new Rect(container.x,container.y,200,100),"关卡："+level,aa);
		GUI.Label(new Rect(container.x,container.y +70,200,100),"剩余障碍："+avalueblock,aa);

		vec.x = x * 64;
		vec.y = (9 - y) * 64;
		vec_screen = Camera.main.WorldToScreenPoint (vec);//将鼠标的世界坐标转换成屏幕坐标

		if (heroscript.finish == true && moneyscript.finish == false)//you won the game
		{
			Vector2 door = Camera.main.WorldToScreenPoint(new Vector2(480,500));//以传送门为参照物
			moneyscript.walk = false;

			int temlevel = PlayerPrefs.GetInt ("LEVEL");
			if( temlevel == level)
			{
				temlevel++;
				PlayerPrefs.SetInt ("LEVEL",temlevel);
			}

			GUI.Label(new Rect(door.x-100,door.y - 400,200,30),"You Won",bb);
			if(GUI.Button(new Rect(door.x-100,door.y - 300,190,79),nextImage))
			{
				StartCoroutine ("LoadNextScene");
			}
			if(GUI.Button(new Rect(door.x-100,door.y - 200,190,79),againImage))
			{
				StartCoroutine ("LoadCurrentScene");
			}
			if(GUI.Button(new Rect(door.x-100,door.y - 100,190,79),mainImage))
			{
				StartCoroutine ("LoadMainScene");
			}
		}
		else if(heroscript.finish == false && moneyscript.finish == true)//you lose the game
		{
			heroscript.walk = false;
			Vector2 door = Camera.main.WorldToScreenPoint(new Vector2(480,500));
			GUI.Label(new Rect(door.x-100,door.y - 400,161,61),"You Lose",bb);
			if(GUI.Button(new Rect(door.x-100,door.y - 300,190,79),againImage))
			{
				StartCoroutine ("LoadCurrentScene");
			}
			if(GUI.Button(new Rect(door.x-100,door.y - 200,190,79),mainImage))
			{
				StartCoroutine ("LoadMainScene");
			}

		}
	}

	void OnMouseUp (){
		int value = level8.GetMapValue ((int)x, (int)y);
		if(value == 0)
		{
			if (heroscript.walk == false && heroscript.finish == false && moneyscript.walk == false && moneyscript.finish == false) {
				level8.SetMap ((int)x, (int)y, 2);//设置地图
				heroscript.InitGame ();
				moneyscript.InitGame ();
				if (heroscript.astar.findPath (heroscript.grid) == true && moneyscript.astar.findPath (moneyscript.grid) == true && avalueblock > 0) {
					GameObject down = Instantiate (rock, new Vector2 (x * 64 + 32, y * 64 + 32), Quaternion.Euler (new Vector3 (0, 0, 0))) as GameObject;
					avalueblock--;
				} else {
					level8.SetMap ((int)x, (int)y, 0);//设置地图
				}
			}
		}
	}

	// Update is called once per frame
	void Update () {
		Vector2 mousepos =  Camera.main.ScreenToWorldPoint (Input.mousePosition);
		x = (int)mousepos.x / 64;
		y = (int)mousepos.y / 64;
	}

	AsyncOperation asyn;
	IEnumerator LoadNextScene()//next stage
	{
		yield return new WaitForSeconds(1);
		asyn = Application.LoadLevelAsync ("level12");
		yield return new WaitForSeconds(1);
	}
	IEnumerator LoadCurrentScene()//try again
	{
		yield return new WaitForSeconds(1);
		asyn = Application.LoadLevelAsync ("level8");
		yield return new WaitForSeconds(1);
	}
	IEnumerator LoadMainScene()//try again
	{
		yield return new WaitForSeconds(1);
		asyn = Application.LoadLevelAsync ("login");
		yield return new WaitForSeconds(1);
	}
}
