using UnityEngine;
using System.Collections;

public class LevelMap2  {
	public int[,] map= new int[14,10];//map非零为不可走，为1为草丛，为2为石头
	//起名规范：比如第一关起名 Level3Map
	//hero(i = 0,j = 8)
	//enemy(i = 13, j = 1)
	//door(i = 6,j = 3)
	/*
	 初始情况为：刚开始时，有2个rock，当hero吃了蘑菇之后rock块数增加，并且hero
	 速度加快，只要保证吃一块蘑菇增加一点速度，不要加速太快，就能有取胜的办法。
	*/
	
	//地图信息如果为0，则为空地
	//为1，则为预设的不可走
	//为2，则为用户自己添加的障碍物
	//为4，则为起点或者终点
	//为5,则表示可以吃的东西，吃了可以产生更多的rock，并且可以加速。
	// Use this for initialization
	public void Initial(){//初始化信息
		for (int i =0; i< 14; i++) {//初始化地图所有方格,周围一圈为草丛
			for (int j =0; j< 10; j++) {
				map [i, j] = 0;
			}
		}
		map[0, 2] = 1;
		map[0, 7] = 1;
		map[0, 9] = 1;
		map[1, 2] = 1;
		map[1, 8] = 1;
		map[2, 1] = 1;
		map[3, 2] = 1;
		map[3, 3] = 1;
		map[3, 6] = 1;
		map[4, 3] = 1;
		map[4, 6] = 1;
		map[5, 3] = 1;
		map[6, 2] = 1;
		map[6, 3] = 1;
		map[6, 6] = 1;
		map[7, 6] = 1;
		map[8, 0] = 1;
		map[8, 1] = 1;
		map[8, 2] = 1;
		map[8, 6] = 1;
		map[9, 6] = 1;
		map[10, 1] = 1;
		map[10, 4] = 1;
		map[10, 5] = 1;
		map[11, 3] = 1;
		map[12, 0] = 1;
		map[12, 3] = 1;
		map[12, 8] = 1;
		map[13, 1] = 1;
	}
	public void SetMap(int x,int y,int value)
	{
		map [x, y] = value;
	}
	public int GetMapValue(int x,int y)
	{
		return map [x, y];
	}
}