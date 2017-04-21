using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public PlayerController player;

    private float movingDistance;
    private Vector3 lastPlayerPos;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        lastPlayerPos = player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        movingDistance = player.transform.position.x - lastPlayerPos.x;
        transform.position = new Vector3(transform.position.x + movingDistance, transform.position.y, transform.position.z);
        lastPlayerPos = player.transform.position;
	}
}
