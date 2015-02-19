using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Acos : MonoBehaviour
{
		public Transform cube;
		public Text displayText;
		public float speed = 1;
		string text;
		// Use this for initialization
		void Start ()
		{
				speed = speed / 10;
				
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				speed = Mathf.Clamp (speed, 0, 1);
				
				cube.rotation = Quaternion.AngleAxis (Mathf.Acos (speed) * Mathf.Rad2Deg, Vector3.right);
				
					
				text = "Cos Value : " + speed + "\nMathf.Acos angle :" + Mathf.Acos (speed) * Mathf.Rad2Deg + "";
				displayText.text = text;
		}

}
