using UnityEngine;
using System.Collections;

public class Other : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
//				MathfApproximately ();
				//CeilExample ();
				//CeilToIntExample ();
				//	ClosestPowerOfTwoExample ();
				//FloorExample ();
				//	FloorToIntExample ();
			
		}
	
		// Update is called once per frame
		void Update ()
		{
				MoveTowards ();
		}


		void MathfApproximately ()
		{
				if (Mathf.Approximately (1.0F, 0.9999999999f)) {
						print ("same");
				}
				if (1.0f == 0.999999999) {
						print ("Equal");
				}
		}
		void CeilExample ()
		{
				Debug.Log (Mathf.Ceil (10.0F));
				Debug.Log (Mathf.Ceil (10.2F));
				Debug.Log (Mathf.Ceil (10.7F));
				Debug.Log (Mathf.Ceil (-10.0F));
				Debug.Log (Mathf.Ceil (-10.2F));
				Debug.Log (Mathf.Ceil (-10.7F));
		}
		void CeilToIntExample ()
		{
				Debug.Log (Mathf.CeilToInt (10.0F));
				Debug.Log (Mathf.CeilToInt (10.2F));
				Debug.Log (Mathf.CeilToInt (10.7F));
				Debug.Log (Mathf.CeilToInt (-10.0F));
				Debug.Log (Mathf.CeilToInt (-10.2F));
				Debug.Log (Mathf.CeilToInt (-10.7F));
		}
		void ClosestPowerOfTwoExample ()
		{
				Debug.Log (Mathf.ClosestPowerOfTwo (7));
				Debug.Log (Mathf.ClosestPowerOfTwo (19));
		}
		void FloorExample ()
		{
				Debug.Log (Mathf.Floor (10.0F));
				Debug.Log (Mathf.Floor (10.2F));
				Debug.Log (Mathf.Floor (10.7F));
				Debug.Log (Mathf.Floor (-10.0F));
				Debug.Log (Mathf.Floor (-10.2F));
				Debug.Log (Mathf.Floor (-10.7F));
		}
		void FloorToIntExample ()
		{
				Debug.Log (Mathf.FloorToInt (10.0F));
				Debug.Log (Mathf.FloorToInt (10.2F));
				Debug.Log (Mathf.FloorToInt (10.7F));
				Debug.Log (Mathf.FloorToInt (-10.0F));
				Debug.Log (Mathf.FloorToInt (-10.2F));
				Debug.Log (Mathf.FloorToInt (-10.7F));
		}
		public float currStrength;
		public float maxStrength;
		public float recoveryRate;
		void MoveTowards ()
		{
				currStrength = Mathf.MoveTowards (currStrength, maxStrength, recoveryRate * Time.deltaTime);
		}
}
