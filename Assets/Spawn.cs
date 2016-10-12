using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	//lager en referanse til prefaben.
	public GameObject capsulePrefab; 
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			Vector3 spawnPoint = new Vector3 (Random.Range (-10f, 10), 0, Random.Range (-10f, 10));
			Vector3 spawnRotation = Vector3.up * Random.Range (0,360);

			/*Instantiate har 3 innparamtere: Objectreferanse, Vector3 til punket hvor objectet skal instansieres, Kvaternion til rotasjonen.
			 * Quaternion.Euler konverter en vector3 til kvaternion.
			 * 
			 * GameObject newCapsule lager ett nytt GameObject, for å gjøre det KAN man bruke "casting". I dette tilfellet er (GameObject) det som instantiate skal
			 * "kastes" til. Instantiate lager ikke et GameObject, men et vanlig object. 
			*/
			GameObject newCapsule = (GameObject)Instantiate (capsulePrefab, spawnPoint, Quaternion.Euler (spawnRotation));
			//setter den nye kapselen som parent til GameObjectet scriptet er koblet til.
			newCapsule.transform.parent = transform;
            int start = 3;
            // Denne skrev jeg fra min stasjonære pc.
            //Denne linjen skrev jeg fra min laptop
		} 
	}
}
