using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
	Transform tf;
	public float speed = 1.0f;
	public float scaleRate = 5.0f;

	// Use this for initialization
	void Start ()
	{
		tf = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

		// Move Sprite
		if (Input.GetKey(KeyCode.W))
		{
			Debug.Log("W key");
			tf.position += transform.up * Time.deltaTime * speed;
		}
		if (Input.GetKey(KeyCode.S))
		{
			Debug.Log("S key");
			tf.position -= transform.up * Time.deltaTime * speed;
		}
		if (Input.GetKey(KeyCode.A))
		{
			Debug.Log("A key");
			tf.position -= transform.right * Time.deltaTime * speed;
		}
		if (Input.GetKey(KeyCode.D))
		{
			Debug.Log("D key");
			tf.position += transform.right * Time.deltaTime * speed;
		}

		// Scale Sprite
		/*
		if (Input.GetKey(KeyCode.M))
		{
			tf.localScale += new Vector3(0.1f, 0.1f, 0.0f);
		}
		if (Input.GetKey(KeyCode.N))
		{
			tf.localScale -= new Vector3(0.1f, 0.1f, 0.0f);
		}
		*/

		/*
		float scaleAmount = Input.GetAxis("scale") * Time.deltaTime * scaleRate;
		//Debug.Log("scaleAmount=" + scaleAmount);
		transform.localScale += Vector3.one * scaleAmount;
		*/

		if (Input.GetKey(KeyCode.Escape))
		{
			Debug.Log("Application.Quit");
			Application.Quit();

		}
	}
}
