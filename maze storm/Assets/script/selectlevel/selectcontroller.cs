using UnityEngine;
using System.Collections;

public class selectcontroller : MonoBehaviour {
	private MusicPlayer mup;
	public GameObject locked;//要放下的障碍物

	// Use this for initialization
	void Start () {
		GameObject mupobj = GameObject.Find ("audio(Clone)"); //调用脚本background中的地图
		mup = (MusicPlayer)mupobj.GetComponent (typeof(MusicPlayer));


		GameObject sltobj1 = GameObject.Find ("btn1"); //调用脚本info中的地图
		Vector2 sltpos1 =  sltobj1.transform.position;
		Vector2 container1 = Camera.main.WorldToScreenPoint(new Vector2(sltpos1.x,sltpos1.y));//以容器参照物
		
		GameObject sltobj2 = GameObject.Find ("btn2"); //调用脚本info中的地图pos2.y));//以容器参照物
		Vector2 sltpos2 =  sltobj2.transform.position;
		Vector2 container2 = Camera.main.WorldToScreenPoint(new Vector2(sltpos2.x,sltpos2.y));//以容器参照物
		
		GameObject sltobj3 = GameObject.Find ("btn3"); //调用脚本info中的地图
		Vector2 sltpos3 =  sltobj3.transform.position;
		Vector2 container3 = Camera.main.WorldToScreenPoint(new Vector2(sltpos3.x,sltpos3.y));//以容器参照物
		
		GameObject sltobj4 = GameObject.Find ("btn4"); //调用脚本info中的地图
		Vector2 sltpos4 =  sltobj4.transform.position;
		Vector2 container4 = Camera.main.WorldToScreenPoint(new Vector2(sltpos4.x,sltpos4.y));//以容器参照物
		
		GameObject sltobj5 = GameObject.Find ("btn5"); //调用脚本info中的地图
		Vector2 sltpos5 =  sltobj5.transform.position;
		Vector2 container5 = Camera.main.WorldToScreenPoint(new Vector2(sltpos5.x,sltpos5.y));//以容器参照物
		
		GameObject sltobj6 = GameObject.Find ("btn6"); //调用脚本info中的地图
		Vector2 sltpos6 =  sltobj6.transform.position;
		Vector2 container6 = Camera.main.WorldToScreenPoint(new Vector2(sltpos6.x,sltpos6.y));//以容器参照物
		
		GameObject sltobj7 = GameObject.Find ("btn7"); //调用脚本info中的地图
		Vector2 sltpos7 =  sltobj7.transform.position;
		Vector2 container7 = Camera.main.WorldToScreenPoint(new Vector2(sltpos7.x,sltpos7.y));//以容器参照物
		
		GameObject sltobj8 = GameObject.Find ("btn8"); //调用脚本info中的地图
		Vector2 sltpos8 =  sltobj8.transform.position;
		Vector2 container8 = Camera.main.WorldToScreenPoint(new Vector2(sltpos8.x,sltpos8.y));//以容器参照物
		
		GameObject sltobj9 = GameObject.Find ("btn9"); //调用脚本info中的地图
		Vector2 sltpos9 =  sltobj9.transform.position;
		Vector2 container9 = Camera.main.WorldToScreenPoint(new Vector2(sltpos9.x,sltpos9.y));//以容器参照物
		
		GameObject sltobj10 = GameObject.Find ("btn10"); //调用脚本info中的地图
		Vector2 sltpos10 =  sltobj10.transform.position;
		Vector2 container10 = Camera.main.WorldToScreenPoint(new Vector2(sltpos10.x,sltpos10.y));//以容器参照物
		
		GameObject sltobj11 = GameObject.Find ("btn11"); //调用脚本info中的地
		Vector2 sltpos11 =  sltobj11.transform.position;
		Vector2 container11 = Camera.main.WorldToScreenPoint(new Vector2(sltpos11.x,sltpos11.y));//以容器参照物
		
		GameObject sltobj12 = GameObject.Find ("btn12"); //调用脚本info中的地图
		Vector2 sltpos12 =  sltobj12.transform.position;
		Vector2 container12 = Camera.main.WorldToScreenPoint(new Vector2(sltpos12.x,sltpos12.y));//以容器参照物
		
		GameObject sltobj13 = GameObject.Find ("btn13"); //调用脚本info中的地图
		Vector2 sltpos13 =  sltobj13.transform.position;
		Vector2 container13 = Camera.main.WorldToScreenPoint(new Vector2(sltpos13.x,sltpos13.y));//以容器参照物
		
		GameObject sltobj14 = GameObject.Find ("btn14"); //调用脚本info中的地图
		Vector2 sltpos14 =  sltobj14.transform.position;
		Vector2 container14 = Camera.main.WorldToScreenPoint(new Vector2(sltpos14.x,sltpos14.y));//以容器参照物
		
		GameObject sltobj15 = GameObject.Find ("btn15"); //调用脚本info中的地图
		Vector2 sltpos15 =  sltobj15.transform.position;
		Vector2 container15 = Camera.main.WorldToScreenPoint(new Vector2(sltpos15.x,sltpos15.y));//以容器参照物
		
		
		
		if (PlayerPrefs.GetInt ("LEVEL") < 2) 
		{
			//sltobj2.SetActive(false);
			Instantiate(locked,new Vector2(container2.x,container2.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 3) 
		{
			//sltobj3.SetActive(false);
			Instantiate(locked,new Vector2(container3.x,container3.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 4) 
		{
			//sltobj4.SetActive(false);
			Instantiate(locked,new Vector2(container4.x,container4.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 5) 
		{
			//sltobj5.SetActive(false);
			Instantiate(locked,new Vector2(container5.x,container5.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 6) 
		{
			//sltobj6.SetActive(false);
			Instantiate(locked,new Vector2(container6.x,container6.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 7) 
		{
			//sltobj7.SetActive(false);
			Instantiate(locked,new Vector2(container7.x,container7.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 8) 
		{
			//sltobj8.SetActive(false);
			Instantiate(locked,new Vector2(container8.x,container8.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 9) 
		{
			//sltobj9.SetActive(false);
			Instantiate(locked,new Vector2(container9.x,container9.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 10) 
		{
			//sltobj10.SetActive(false);
			Instantiate(locked,new Vector2(container10.x,container10.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 11) 
		{
			//sltobj11.SetActive(false);
			Instantiate(locked,new Vector2(container11.x,container11.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 12) 
		{
			//sltobj12.SetActive(false);
			Instantiate(locked,new Vector2(container12.x,container12.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 13) 
		{
			//sltobj13.SetActive(false);
			Instantiate(locked,new Vector2(container13.x,container13.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 14) 
		{
			//sltobj14.SetActive(false);
			Instantiate(locked,new Vector2(container14.x,container14.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
		if (PlayerPrefs.GetInt ("LEVEL") < 15) 
		{
			//sltobj15.SetActive(false);
			Instantiate(locked,new Vector2(container15.x,container15.y),Quaternion.Euler(new Vector3(0,0,0)));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{


	}
}
