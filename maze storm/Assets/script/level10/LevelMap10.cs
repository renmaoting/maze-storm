using UnityEngine;
using System.Collections;

public class LevelMap10  {
	public int[,] map= new int[14,10];//map非零为不可走，为1为草丛，为2为石头
	//起名规范：比如第一关起名 Level3Map
	//hero(0,9)
	//enemy(6,4)
	//door(13,0)
	//difficulty (0.5)
	
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
		map[2, 4] = 1;
		map[4, 2] = 1;
		map[4, 6] = 1;
		map[6, 0] = 1;
		map[6, 2] = 1;
		map[6, 6] = 1;
		map[6, 8] = 1;
		map[8, 2] = 1;
		map[8, 6] = 1;
		map[10, 2] = 1;
		map[10, 6] = 1;
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