using UnityEngine;
using System.Collections;

public class LevelMap4  {
	public int[,] map= new int[14,10];//map非零为不可走，为1为草丛，为2为石头
	//起名规范：比如第一关起名 Level1Map
	//hero(1,9)
	//enemy(4,5)
	//door(13,0)
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
		map[1, 4] = 1;
		map[1, 8] = 1;
		map[2, 0] = 1;
		map[2, 5] = 1;
		map[2, 9] = 1;
		map[4, 2] = 1;
		map[4, 7] = 1;
		map[5, 3] = 1;
		map[5, 8] = 1;
		map[6, 0] = 1;
		map[6, 4] = 1;
		map[7, 1] = 1;
		map[8, 2] = 1;
		map[8, 6] = 1;
		map[9, 7] = 1;
		map[10, 4] = 1;
		map[10, 8] = 1;
		map[11, 1] = 1;
		map[11, 5] = 1;
		map[12, 2] = 1;
		map[12, 6] = 1;
		map[13, 3] = 1;
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