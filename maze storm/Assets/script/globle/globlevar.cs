using UnityEngine;
using System.Collections;

public class globlevar : MonoBehaviour {

	public AudioSource Sound;
	private static globlevar instance;
	public static globlevar getInstance{
		get{
			if(instance==null){
				instance=new globlevar();
			}
			return instance;
		}
	}
	public void Play(string str)
	{
		Sound.clip = (AudioClip)Resources.Load(str, typeof(AudioClip));//调用Resources方法加载AudioClip资源
		Sound.Play();
	}
}
