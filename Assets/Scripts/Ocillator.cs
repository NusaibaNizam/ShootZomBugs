using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ocillator : MonoBehaviour {
    public float timer;
    public float newTarget;
    public float speed;
    public NavMeshAgent nav;
    public Vector3 target;
    GameObject player;
	// Use this for initialization
	void Start () {
        nav = gameObject.GetComponent<NavMeshAgent>();
        timer = 0;
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer>=newTarget)
        {
            NewTarget();
            timer = 0;
        }
        nav.speed = speed;
        transform.Rotate(new Vector3(0,1000000,0) * Time.deltaTime);

    }
    void NewTarget()
    {
        float x = gameObject.transform.position.x;
        float z = gameObject.transform.position.z;
        float newX = x + Random.Range( x-100,x+100);
        float newZ = z + Random.Range( z-100,z+100);
        target = new Vector3(newX, gameObject.transform.position.y,newZ);
        nav.SetDestination(target);
    }
}
