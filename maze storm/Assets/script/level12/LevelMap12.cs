using UnityEngine;
using System.Collections;

public class LevelMap12  {
	public int[,] map= new int[14,10];//map非零为不可走，为1为草丛，为2为石头
	//起名规范：比如第一关起名 Level3Map
	//hero(7,0)
	//enemy(5,3)
	//door(7,7)
	//difficulty (0.2)
	
	//地图信息如果为0，则为空地
	//为1，则为预设的不可走
	//为2，则为用户自己添加的障碍物
	//为4，则为起点或者终点
	// Use this for initialization
	public void Initial(){//初始化信息
		for (int i =0; i< 14; i++) {//初始化地图所有方格,周围一圈  ！不是!   草丛
			for (int j =0; j< 10; j++) {
				map [i, j] = 0;
			}
		}
		map[0, 0] = 1;
		map[0, 5] = 1;
		map[0, 7] = 1;
		map[0, 9] = 1;
		map[1, 7] = 1;
		map[2, 9] = 1;
		map[3, 8] = 1;
		map[4, 3] = 1;
		map[4, 9] = 1;
		map[5, 3] = 1;
		map[5, 5] = 1;
		map[6, 3] = 1;
		map[6, 9] = 1;
		map[7, 3] = 1;
		map[8, 3] = 1;
		map[8, 7] = 1;
		map[9, 3] = 1;
		map[9, 8] = 1;
		map[10, 3] = 1;
		map[11, 3] = 1;
		map[11, 4] = 1;
		map[11, 5] = 1;
		map[11, 7] = 1;
		map[11, 8] = 1;
		map[12, 1] = 1;
		map[12, 8] = 1;
	}
	// map[5, 3] = 4; 
	// map[7, 0] = 4;
	// map[7, 7] = 4;

	
	
	public void SetMap(int x,int y,int value)
	{
		map [x, y] = value;
	}
	public int GetMapValue(int x,int y)
	{
		return map [x, y];
	}
}