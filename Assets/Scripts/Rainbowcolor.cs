using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbowcolor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine() {
        color:
        gameObject.GetComponent<Renderer> ().material.color = Color.white;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Renderer> ().material.color = Color.grey;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Renderer> ().material.color = Color.black;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Renderer> ().material.color = Color.cyan;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Renderer> ().material.color = Color.green;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Renderer> ().material.color = Color.magenta;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Renderer> ().material.color = Color.red;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Renderer> ().material.color = Color.white;
        goto color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
