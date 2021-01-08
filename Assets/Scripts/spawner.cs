using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
    public GameObject player;
    public GameObject objects;
    int health;
    int random,ran,rand;
    float timer;
    Vector3 spawnPoint, spawnPoint1;
    GameObject a,b,c;
    public static AudioSource beep;
	// Use this for initialization
	void Start () {
        beep = gameObject.GetComponent<AudioSource>();
        timer = 0;
        health = PlayerHealth.currentHealth;
	}
	
	// Update is called once per frame
	void Update () {
        health = PlayerHealth.currentHealth;
        timer += Time.deltaTime;
        random = Random.Range(0, 4);
        ran = Random.Range(0, 4);
        rand = Random.Range(0, 4);
        spawnPoint = new Vector3(player.transform.position.x + ran, player.transform.position.y, player.transform.position.z + rand);
        spawnPoint1 = new Vector3(player.transform.position.x + rand, player.transform.position.y, player.transform.position.z + random);
        if (timer >= 2&& health<190)
        {
            a = Instantiate(objects, spawnPoint, Quaternion.identity);
            timer = -6;
        }
        if (timer >= 2 && health < 180&&health>0)
        {
            b = Instantiate(objects, spawnPoint1, Quaternion.identity);
            timer = -3;
        }
            }
}
