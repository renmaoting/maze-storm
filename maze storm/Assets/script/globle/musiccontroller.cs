using UnityEngine;
using System.Collections;

public class musiccontroller : MonoBehaviour {
	public MusicPlayer music;
	public static bool isplay = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		GameObject audio = GameObject.Find ("audio(Clone)");
		music = (MusicPlayer)audio.GetComponent (typeof(MusicPlayer));
		if (isplay == true) 
		{
			music.Stop ();
			isplay = false;
		}
		else
		{
			music.Play();
			isplay = true;
		}

	}
}
