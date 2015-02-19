using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ABsExample : MonoBehaviour
{

	
		public Transform cube;
		public Text displayText;
		public float speed = 1;
		string text;
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				
				cube.position = new Vector3 (Mathf.PingPong (Time.time * speed, -2), 0, 0);



				text = "Position " + cube.position + "absolute value\n" + new Vector3 (Mathf.Abs (cube.position.x), 0, 0);
				displayText.text = text;
		}

}
