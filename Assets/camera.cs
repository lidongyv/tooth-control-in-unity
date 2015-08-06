using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	public float minFov = 15f;
	public float maxFov = 90f;
	public float sensitivity = 10f;
	public float roate_Speed=2f;//旋转速度
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.W))
		{
			print("----------w"); 
			transform.Translate (Vector3.forward * Time.deltaTime*6);
		}
		if(Input.GetKey (KeyCode.S))
		{
			
			print("---------------s");
			transform.Translate (Vector3.forward * Time.deltaTime*-6);
		}
		if(Input.GetKey (KeyCode.A))
		{
			print("---a");
			transform.Rotate(Vector3.up * Time.deltaTime*-6);
		}
		if(Input.GetKey (KeyCode.D))
		{
			
			print("------------d");
			transform.Rotate(Vector3.up * Time.deltaTime*6);
		}
		if(Input.GetKey (KeyCode.Q))
		{
			print("---Q");
			transform.Translate (Vector3.left * Time.deltaTime*6);
		}
		if(Input.GetKey (KeyCode.E))
		{
			
			print("------------E");
			transform.Translate (Vector3.left * Time.deltaTime*-6);
		}
		if(Input.GetKey (KeyCode.Z))
		{
			print("---Q");
			transform.Translate (Vector3.up * Time.deltaTime*6);
		}
		if(Input.GetKey (KeyCode.C))
		{
			
			print("------------E");
			transform.Translate (Vector3.up * Time.deltaTime*-6);
		}
		if(Input.GetKey (KeyCode.F))
		{
			print("---Q");
			transform.Rotate (Vector3.left * Time.deltaTime*6);
		}
		if(Input.GetKey (KeyCode.G))
		{
			
			print("------------E");
			transform.Rotate (Vector3.left * Time.deltaTime*-6);
		}
		/*
		float fov = Camera.main.fieldOfView;
		fov += -Input.GetAxis("Mouse ScrollWheel") * sensitivity;
		fov = Mathf.Clamp(fov, minFov, maxFov);
		Camera.main.fieldOfView = fov;
		float mousX = Input.GetAxis("Mouse X") * roate_Speed;//得到鼠标移动距离
		transform.Rotate(new Vector3(0, mousX, 0));
		float mousY = Input.GetAxis("Mouse Y") * roate_Speed;//得到鼠标移动距离
		transform.Rotate(new Vector3(mousY, 0,0));
*/


	}
}
