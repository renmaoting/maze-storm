﻿using UnityEngine;
using System.Collections;

public class LevelMap7  {
	public int[,] map= new int[14,10];//map非零为不可走，为1为草丛，为2为石头

	//地图信息如果为0，则为空地
	//为1，则为预设的不可走
	//为2，则为用户自己添加的障碍物
	//为3，则为用户添加了一个物体但又删除掉了
	//为4，则为起点或者终点
	// Use this for initialization
	public void Initial(){//初始化信息
		for (int i =0; i< 14; i++) {//初始化地图所有方格,周围一圈为草丛
			for (int j =0; j< 10; j++) {
				if(i == 0 || i == 13 || j == 0 || j == 9||(j == 7 && i!= 8) || (i == 4 && j>= 2 && j<= 7) ||(j ==5 && i>= 4 && i<= 11 && i!=8)
				   ||(i == 3 && j == 3) ||(i == 6 && j == 4) || (i == 11 && j == 4)|| (i == 7 && j>= 2 && j<= 7 && j!=4))
				{
					map[i, j] = 1;
				}
				else
					map [i, j] = 0;
			}
		}
	}
	public void SetMap(int x,int y,int value)
	{
		map [x, y] = value;
	}
	public int GetMapValue(int x,int y)
	{
		return map [x, y];
	}
}///初始位置hero（i ==3,j==5);enemy(i == 10,j== 3);左半门（i == 7,j == 5);右半门（i == 8,j == 5)