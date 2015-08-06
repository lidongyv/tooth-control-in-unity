using UnityEngine;
using System.Collections;

public class light : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.U))
		{
			print("----------up"); 
			transform.Translate (Vector3.forward * Time.deltaTime*20);
		}
		if(Input.GetKey (KeyCode.O))
		{
			
			print("---------------down");
			transform.Translate (Vector3.forward * Time.deltaTime*-20);
		}
		if(Input.GetKey (KeyCode.I))
		{
			print("----------up"); 
			transform.Rotate (Vector3.left * Time.deltaTime*20);
		}
		if(Input.GetKey (KeyCode.K))
		{
			
			print("---------------down");
			transform.Rotate (Vector3.left * Time.deltaTime*-20);
		}
		if(Input.GetKey (KeyCode.J))
		{
			print("---left");
			transform.Translate(Vector3.left  * Time.deltaTime*1);
		}
		if(Input.GetKey (KeyCode.L))
		{
			
			print("------------right");
			transform.Translate(Vector3.left  * Time.deltaTime*-1);
		}
		if(Input.GetKey (KeyCode.X))
		{
			toothmove.i=5;

		}	
		if(Input.GetKey (KeyCode.V))
		{
			toothmove.i=1;

		}	
		if(Input.GetKey (KeyCode.B))
		{
			toothmove.i=2;
		}	
		if(Input.GetKey (KeyCode.N))
		{
			toothmove.i=3;
		}	
		if(Input.GetKey (KeyCode.M))
		{
			toothmove.i=4;
		}	
		if(Input.GetKey (KeyCode.H))
		{
			toothmove.i=0;
		}
	}
}
