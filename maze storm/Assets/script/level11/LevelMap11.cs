using UnityEngine;
using System.Collections;

public class LevelMap11  {
	public int[,] map= new int[14,10];//map非零为不可走，为1为草丛，为2为石头
	//起名规范：比如第一关起名 Level3Map
	//hero(6,8)
	//enemy(6,3)
	//door(6,0)
	//difficulty (0.4)
	
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
		map[1, 6] = 1;
		map[3, 3] = 1;
		map[3, 8] = 1;
		map[6, 2] = 1;
		map[6, 7] = 1;
		map[9, 3] = 1;
		map[9, 8] = 1;
		map[10, 7] = 1;
	}
	// map[6, 0] = 4; 
	// map[6, 3] = 4;
	// map[6, 8] = 4;

	
	public void SetMap(int x,int y,int value)
	{
		map [x, y] = value;
	}
	public int GetMapValue(int x,int y)
	{
		return map [x, y];
	}
}