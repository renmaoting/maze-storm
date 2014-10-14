using UnityEngine;
using System.Collections.Generic;
using System;

public class Play : MonoBehaviour {
	
	Grid _grid;
	AStar astar;
	public Texture2D image1;
	public Texture2D image2;
	public Texture2D image3;
	public Texture2D image4;
	string text = "";
	public static bool ShowPath = false;
	// Use this for initialization
	void Start () {
	   _grid = new Grid(50,30);
	   _grid.SetStartNode(0,2);
	   _grid.SetEndNode(48,10);
	   astar = new AStar();
	   if(astar.findPath(_grid))
	   {
		   for(int i = 0; i<astar._path.Count;i++)
		   {
			     text += "("+astar._path[i].x+","+astar._path[i].y+")"+"  ";
		   }
		   Debug.Log(text);
	   }
	}
	
	void OnGUI()
	{
		for(int i = 0;i<_grid.GetNumCols();i++)
		{
			for(int j = 0;j<_grid.GetNumRows();j++)
			{
				if(_grid.getNode(i,j).walkbale == false)
				{
					GUI.DrawTexture(new Rect(i*20,j*20,20,20),image3);
				}
				else
				{
				   GUI.DrawTexture(new Rect(i*20,j*20,20,20),image2);
				}
			}
		}
		for(int i = 0;i<astar._open.Count;i++)
		{
			GUI.DrawTexture(new Rect(astar._open[i].x*20,astar._open[i].y*20,20,20),image4);
		}
		for(int i = 0; i<astar._path.Count;i++)
		{
		   if(ShowPath)
		   {
			  GUI.DrawTexture(new Rect(astar._path[i].x*20,astar._path[i].y*20,20,20),image1);
		   }
		}
	}
	
	// Update is called once per frame
	void Update () {
	   if(Input.GetMouseButtonDown(0))
	   {
			Vector2 mouseposition = Input.mousePosition;
			int xpos = (int)Mathf.Floor(mouseposition.x/20);
			int ypos = (int)Mathf.Floor((Screen.height-mouseposition.y)/20);
			_grid.SetWalkbale(xpos,ypos,!_grid.getNode(xpos,ypos).walkbale);
			astar.findPath(_grid);
	   }
	}
}
