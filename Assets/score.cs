using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public float Score;
    public Text scoreUI;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("point"))
        {
            Score += 50;
            scoreUI.text = "Score : " + Score.ToString();
            Destroy(collision.collider.gameObject);

        }
    }
}
