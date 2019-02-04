using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour
{
	public GameObject prefab1;
	
	public GameObject prefab2;
	
	public GameObject prefab3;
	
	public GameObject prefab4;
	
	public GameObject prefab5;
	
	public GameObject prefab6;
	
	public int platform;
	
	// Use this for initialization
	void Start () {
		
		InvokeRepeating("CreateObstacle", 1f, 1.5f); 
		
	}
	
	
	
	void CreateObstacle()
	{
		platform = Random.Range (1, 3);             //Gerador das bolinhas la
        float RandomX = Random.Range(249.5f, 248.9f);
        float RandomY = Random.Range(93.8f, 93.81f);
		float RandomZ = Random.Range(225.37f, 257.73f);
		               // Dar as coordenadas das bolinhas!
		
		switch (platform)
		{
		case 1: 
			Instantiate(prefab1, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity); 
			break;
		case 2:
			Instantiate(prefab2, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		case 3: 
			Instantiate(prefab3, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		case 4: 
			Instantiate(prefab4, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		case 5: 
			Instantiate(prefab5, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		case 6: 
			Instantiate(prefab6, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		}
		
	}
}