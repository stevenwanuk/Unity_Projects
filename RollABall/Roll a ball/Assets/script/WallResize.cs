using UnityEngine;
using System.Collections;

public class WallResize : MonoBehaviour {

    public GameObject ground;
    public string position;

	// Use this for initialization
	void Start () {

        Debug.Log(ground.transform.right);
        //mesh.bounds.size.x = 10
        //transform.localScale.x = 5
        //mesh.bounds.size.x * transform.localScale.x = 50
    }

    // Update is called once per frame
    void Update () {
	
	}
}
