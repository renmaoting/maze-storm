using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {
	public GameObject music;//要放下的障碍物
	void Start()
	{
		Screen.SetResolution (1136, 640, true);
		if(GameObject.Find ("audio(Clone)") == null) //调用脚本background中的地图
			Instantiate (music, new Vector2 (0,0), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}
	void OnMouseDown()
	{
		//Application.LoadLevel ("level1");
		StartCoroutine ("LoadMainScene");
	}

	AsyncOperation asyn;
	IEnumerator LoadMainScene()
	{
		yield return new WaitForSeconds(1);
		asyn = Application.LoadLevelAsync ("selectlevel");
		yield return new WaitForSeconds(1);
	}
}
