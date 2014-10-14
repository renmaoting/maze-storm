using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grid{
	
	private Node _startNode;
	private Node _endNode;
	public Node[,] _nodes;
	private int _numCols;
	private int _numRows;
	// Use this for initialization
	public Grid(int numCols,int numRows)
	{
		_numCols = numCols;
		_numRows = numRows;
		_nodes = new Node[numCols,numRows];
		for(int i = 0;i<numCols;i++)
		{
			for(int j = 0;j<numRows;j++)
			{
				Node test = new Node(i,j);
				_nodes[i,j] = test;
			}
		}
	}
	
	public Node getNode(int x,int y)
	{
		return _nodes[x,y];
	}
	
	public void SetStartNode(int x,int y)
	{
		_startNode = _nodes[x,y];
	}
	
	public void SetEndNode(int x,int y)
	{
		_endNode = _nodes[x,y];
	}
	
	public void SetWalkbale(int x,int y,bool Value)
	{
		_nodes[x,y].walkbale = Value;
	}
	
	public Node GetEndNode()
	{
		return _endNode;
	}
	
	public Node GetStartNode()
	{
		return _startNode;
	}
	
	public int GetNumCols()
	{
		return (int)_numCols;
	}
	
	public int GetNumRows()
	{
		return (int)_numRows;
	}
}
