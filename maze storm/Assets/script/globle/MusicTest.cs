using UnityEngine;
using System.Collections;

public class MusicTest  : MonoBehaviour {

	private MusicPlayer music;
	
	void Start () {	
		music = (GetComponent("MusicPlayer") as MusicPlayer);//获取播放器对象
	}
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(10, 10, 100, 50), "PLAY")){
			//music.Play("if");//调用播放器Play方法	
		}
	}
}
