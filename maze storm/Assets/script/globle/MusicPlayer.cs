using UnityEngine;
using System.Collections;
using System;
using System.Text;
using System.IO;

public class MusicPlayer : MonoBehaviour {

	public AudioSource Sound;
	public string str = "if";
	//private string filepath="";

	private static MusicPlayer instance;
	public static MusicPlayer getInstance{
		get{
			if(instance==null){
				instance=new MusicPlayer();
			}
			return instance;
		}
	}
	void Start()
	{
		DontDestroyOnLoad(transform.gameObject);
		Sound.clip = (AudioClip)Resources.Load(str, typeof(AudioClip));//调用Resources方法加载AudioClip资源
		Play ();

	}
	public void Play()
	{
		Sound.Play();
	}
	public void Stop()
	{
		Sound.Stop();
	}
}
