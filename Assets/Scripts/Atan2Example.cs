using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Atan2Example : MonoBehaviour
{

		public Transform cube;
		
		public Text displayText;
		public float angle = 1;
		string text;
		public LineRenderer line;
		// Use this for initialization
		void Start ()
		{
				line.SetPosition (0, Vector3.zero);
		}
	
		// Update is called once per frame
		void Update ()
		{

				Vector3 dir = cube.position - Vector3.zero;
				angle = Mathf.Atan2 (dir.x, dir.y) * Mathf.Rad2Deg;
				
				line.SetPosition (1, new Vector3 (dir.x, 0, 0));
				line.SetPosition (2, new Vector3 (dir.x, dir.y, 0));
				line.SetPosition (3, Vector3.zero);
				
				text = "Angle :" + angle;
				displayText.text = text;
		}
}
