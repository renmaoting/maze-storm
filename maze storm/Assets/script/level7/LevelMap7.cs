using UnityEngine;
using System.Collections;

public class LevelMap7  {
	public int[,] map= new int[14,10];//map非零为不可走，为1为草丛，为2为石头
	public void Initial(){//初始化信息
		for (int i =0; i< 14; i++) {//初始化地图所有方格,周围一圈为草丛
			for (int j =0; j< 10; j++) {
				if(i == 0 || i == 13 || j == 0 || j == 9)
				{
					map[i, j] = 1;
				}
				else
				{
					map[i,j] = 0;
				}
			}
		}
		map[1,7] = 2;
		map[2,7] = 2;
		map[3,7] = 2;
		map[4,7] = 2;
		map[5,7] = 2;
		map[6,7] = 2;
		map[7,7] = 2;
		map[9,7] = 2;
		map[10,7] = 2;
		map[11,7] = 2;
		map[12,7] = 2;
		map[3,3] = 2;
		map[4,2] = 2;
		map[4,3] = 2;
		map[4,4] = 2;
		map[4,5] = 2;
		map[4,6] = 2;
		map[5,5] = 2;
		map[6,4] = 2;
		map[6,5] = 2;
		map[7,2] = 2;
		map[7,3] = 2;
		map[7,5] = 2;
		map[7,6] = 2;
		map[9,5] = 2;
		map[10,5] = 2;
		map[11,5] = 2;
		map[11,4] = 2;
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