using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public Transform enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("s"))
        {
            Instantiate(enemy, new Vector3(1, 1, 1), Quaternion.identity);
        }
    }
}
