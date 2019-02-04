using UnityEngine;
using System.Collections;

public class ColisaoEnemys : MonoBehaviour {

    public string sofrencia;
    private int quantidadedesentimentosdestruidos;
    public string Perdeu;



	// Use this for initialization
	void Start () 
	{
    

		quantidadedesentimentosdestruidos = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (quantidadedesentimentosdestruidos == 7)
        {
            Application.LoadLevel(sofrencia);  

        }

	}

    void OnControllerColliderHit(ControllerColliderHit Sentimentos)
	{
        if (Sentimentos.gameObject.tag == "pablo")
        {
            Destroy(Sentimentos.gameObject);
            quantidadedesentimentosdestruidos++;

            Debug.Log(quantidadedesentimentosdestruidos);
        }

        if (Sentimentos.gameObject.tag == "bolinhakikando")
        {
            Application.LoadLevel(Perdeu);
        }
		if (Sentimentos.gameObject.name == "Sam") 
		{
			Application.LoadLevel(sofrencia);	
		}

    }

}