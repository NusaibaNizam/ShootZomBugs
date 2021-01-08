using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Delay : MonoBehaviour {
    public GameObject canvas;
	// Use this for initialization
	void Start () {
        on();
	}
	
	// Update is called once per frame
    void on()
    {
        StartCoroutine(CanvasEnable());
    }
    IEnumerator CanvasEnable()
    {
        yield return new WaitForSeconds(7f);
        canvas.SetActive(true);
    }
}
