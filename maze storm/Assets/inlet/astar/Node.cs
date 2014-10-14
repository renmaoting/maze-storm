using UnityEngine;
using System.Collections;

public class Node{
	
	public int x;
	public int y;
	public float f;
	public float g;
	public float h;
	public bool walkbale = true;
	public Node parent;
	public float CostMultiplier = 1.0f;
	public Node(int x,int y)
	{
		this.x = x;
		this.y = y;
	}
}
