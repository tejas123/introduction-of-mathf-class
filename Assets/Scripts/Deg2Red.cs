using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Deg2Red : MonoBehaviour
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
				cube.localEulerAngles = new Vector3 (Time.time * speed, 90, 0);
				text = "Degrees " + cube.localEulerAngles + "equal to \n" + cube.localEulerAngles * Mathf.Deg2Rad + "Radians";
				displayText.text = text;
		}

}
