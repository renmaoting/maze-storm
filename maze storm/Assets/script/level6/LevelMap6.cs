using UnityEngine;
using System.Collections;

public class LevelMap6  {
	public int[,] map= new int[14,10];//map非零为不可走，为1为草丛，为2为石头
	//起名规范：比如第一关起名 Level1Map
	//hero(0,6)
	//enemy(4,5)
	//door(13,4)
	// 4 块
	
	//地图信息如果为0，则为空地
	//为1，则为预设的不可走
	//为2，则为用户自己添加的障碍物
	//为4，则为起点或者终点
	// Use this for initialization
	public void Initial(){//初始化信息
		for (int i =0; i< 14; i++) {
			for (int j =0; j< 10; j++) {
				map [i, j] = 0;
			}
		}
		map[1, 0] = 1;	
		map[1, 1] = 1;	
		map[1, 3] = 1;	
		map[1, 4] = 1;	
		map[1, 5] = 1;	
		map[1, 5] = 1;
		map[1, 7] = 1;
		map[1, 8] = 1;	
		map[1, 9] = 1;	
		map[2, 1] = 1;
		map[2, 3] = 1;
		map[2, 9] = 1;
		map[4, 1] = 1;
		map[4, 2] = 1;
		map[4, 3] = 1;
		map[4, 4] = 1;
		map[4, 6] = 1;
		map[4, 7] = 1;
		map[4, 8] = 1;
		map[5, 2] = 1;
		map[9, 1] = 1;
		map[9, 2] = 1;
		map[9, 3] = 1;
		map[9, 4] = 1;
		map[9, 5] = 1;
		map[9, 7] = 1;
		map[9, 8] = 1;
		map[9, 9] = 1;
		map[11, 1] = 1;
		map[11, 2] = 1;
		map[11, 3] = 1;
		map[11, 4] = 1;
		map[11, 5] = 1;
		map[11, 6] = 1;
		map[11, 7] = 1;
		map[11, 8] = 1;
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