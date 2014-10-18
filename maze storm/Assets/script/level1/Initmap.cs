using UnityEngine;
using System.Collections;

public class Initmap  {
	public int[,] map= new int[14,10];//map非零为不可走，为1为草丛，为2为石头
	//起名规范：比如第一关起名 Level3Map
	//hero()
	//enemy()
	//door()
	
	//地图信息如果为0，则为空地
	//为1，则为预设的不可走
	//为2，则为用户自己添加的障碍物
	//为4，则为起点或者终点
	// Use this for initialization
	public void Initial(){//初始化信息
		for (int i =0; i< 14; i++) {//初始化地图所有方格,周围一圈为草丛
			for (int j =0; j< 10; j++) {
				if(j==0 ||  j == 9 ||i==0 || i== 13)
					map [i, j] = 1;
				else if( j == 1 || j == 8 || (j >= 2 && j <= 4 && i <= 7) ||
				        (j >= 6 && j <= 7 && i <= 7))
				{
					map[i,j] = 2;
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
}