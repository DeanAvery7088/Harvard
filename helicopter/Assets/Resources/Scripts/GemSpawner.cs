using UnityEngine;
using System.Collections;

public class GemSpawner : MonoBehaviour {

    public GameObject[] prefabs2;

    // Start is called before the first frame update
    void Start(){

        // infinite gem spawning function, asynchronous
		StartCoroutine(SpawnGems());
    }

    // Update is called once per frame
    void Update(){
        
    }

    IEnumerator SpawnGems() {
	    while (true) {

			// number of gems we could spawn vertically
			int gemsThisRow = 1;

			// instantiate all gems in this row separated by some random amount of space
			for (int i = 0; i < gemsThisRow; i++) {
				Instantiate(prefabs2[Random.Range(0, prefabs2.Length)], new Vector3(26, Random.Range(0, 8), 10), Quaternion.identity);
			}

			// pause 12-15 seconds until the next gem spawns
			yield return new WaitForSeconds(Random.Range(12, 15));			
		}
	}
}
