using UnityEngine;
using System.Collections;

public class LevelMap14  {
	public int[,] map= new int[14,10];//map非零为不可走，为1为草丛，为2为石头
	//起名规范：比如第一关起名 Level3Map
	//hero(6,3)
	//enemy(5,5)
	//door(6,3)
	//difficulty (0.7)
	
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
		map[0, 2] = 1;
		map[0, 3] = 1;
		map[1, 1] = 1;
		map[1, 5] = 1;
		map[2, 4] = 1;
		map[2, 7] = 1;
		map[3, 1] = 1;
		map[3, 3] = 1;
		map[3, 8] = 1;
		map[4, 2] = 1;
		map[4, 5] = 1;
		map[4, 6] = 1;
		map[5, 2] = 1;
		map[5, 4] = 1;
		map[6, 5] = 1;
		map[6, 8] = 1;
		map[7, 0] = 1;
		map[7, 2] = 1;
		map[7, 3] = 1;
		map[7, 7] = 1;
		map[8, 6] = 1;
		map[8, 7] = 1;
		map[9, 0] = 1;
		map[9, 2] = 1;
		map[9, 3] = 1;
		map[9, 4] = 1;
		map[10, 1] = 1;
		map[10, 3] = 1;
		map[10, 6] = 1;
		map[11, 3] = 1;
		map[11, 7] = 1;
		map[12, 1] = 1;
		map[12, 3] = 1;
		map[12, 5] = 1;
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