using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class AStar{

	public List<Node> _open;
	public List<Node> _Closed;
	private Grid _grid;
	private Node _endNode;
	private Node _startNode;
	public List<Node> _path;
	private float _straightCost = 1.0f;
	private float _diagCost = Mathf.Sqrt(2);
	private int _numCols;
	private int _numRows;
	public AStar()
	{
	}
	
	public bool findPath(Grid grid)
	{
		_grid = grid;
		_open = new List<Node>();
		_Closed = new List<Node>();
		_startNode = _grid.GetStartNode();
		_endNode = _grid.GetEndNode();
		_numCols = _grid.GetNumCols();
		_numRows = _grid.GetNumRows();
		_startNode.g = 0.0f;
		_startNode.h = manhattan(_startNode);
		_startNode.f = _startNode.g + _startNode.h;
		return Search();
	}
	
	public bool Search()
	{
		Node node = _startNode;
		while(node != _endNode)
		{
			int startX = Mathf.Max(0,node.x-1);
			int endX = Mathf.Min(_numCols-1,node.x+1);
			int startY = Mathf.Max(0,node.y-1);
			int endY = Mathf.Min(_numRows-1,node.y+1);
			for(int i = startX;i<=endX;i++)
			{
				for(int j = startY;j<=endY;j++)
				{
					Node test = _grid.getNode(i,j);
					if(test == node||!test.walkbale||!_grid.getNode(node.x,test.y).walkbale||!_grid.getNode(test.x,node.y).walkbale)
					{
						continue;
					}
					float cost = _straightCost;
					if(!((node.x == test.x)||(node.y == test.y)))
					{
						cost = _diagCost;
					}
					float g = node.g + cost * test.CostMultiplier;
					float h = manhattan(test);
					float f = g+h;
					if(isOpen(test)||isClosed(test))
					{
						if(test.f>f)
						{
							test.f = f;
							test.g = g;
							test.h = h;
							test.parent = node;
						}
					}
					else
					{
						test.f = f;
						test.g = g;
						test.h = h;
						test.parent = node;
						_open.Add(test);
					}
				}
			}
			_Closed.Add(node);
			if(_open.Count == 0)
			{
				Play.ShowPath = false;
				Debug.Log("Can't Find the Path");
				return false;
			}
			else
			{
				Play.ShowPath = true;
			}
			PaiXu();
			node = _open[0];
			_open.RemoveAt(0);
		}
		buildPath();
		return true;
	}
	
	public bool isOpen(Node node)
	{
		bool isFind = false;
		foreach(Node tt in _open)
		{
			if(tt == node)
			{
				isFind = true;
			}
		}
		return isFind;
	}
	
	public bool isClosed(Node node)
	{
		bool isFind = false;
		foreach(Node tt in _Closed)
		{
			if(tt == node)
			{
				isFind = true;
			}
		}
		return isFind;
	}
	
	public void PaiXu()
	{
		for(int i = 0;i<_open.Count-1;i++)
		{
			for(int j = 0;j<_open.Count-1-i;j++)
			{
				if(_open[j].f>_open[j+1].f)
				{
					Node temp = _open[j];
					_open[j] = _open[j+1];
					_open[j+1] = temp;
				}
			}
		}
	}
	
	public void buildPath()
	{
		_path = new List<Node>();
		Node node = _endNode;
		_path.Add(node);
		while(node != _startNode)
		{
			node = node.parent;
			_path.Add(node);
		}
		_path.Reverse();
	}
	
	private float manhattan(Node node)
	{
		return Mathf.Abs(node.x - _endNode.x)*_straightCost + Mathf.Abs(node.y - _endNode.y)*_straightCost;
	}
}
