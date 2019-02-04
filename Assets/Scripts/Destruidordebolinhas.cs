using UnityEngine;
using System.Collections;

public class Destruidordebolinhas : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collision saibol)
	{
		if (saibol.gameObject.name == "Bolinhaquedesce(Clone)" ) 
		{
			Destroy(saibol.gameObject);
		}
	}
	
	
}
