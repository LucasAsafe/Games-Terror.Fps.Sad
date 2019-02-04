using UnityEngine;
using System.Collections;

public class StarInstanti : MonoBehaviour {

	public GameObject Star;
	public int cont,limite;

	void Start () 
	{
		cont = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		cont++;
		
		if (cont == limite) 
		{
			cont = 0;
			
			Instantiate(Star,transform.position,Quaternion.identity);
			
		}
	
	}
}
