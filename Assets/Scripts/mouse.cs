using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
public class mouse: MonoBehaviour {  
     public GameObject pref;
     public GameObject pref1;
  void Start() {}  
  
  // Update is called once per frame    
  void Update() {  
    if (Input.GetKeyDown(KeyCode.E)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) {  
        //mechanika    
        if (hit.transform.name == "BallSpawner") {  
          Instantiate(pref, new Vector3(3f, 0.7f, -2.4f), Quaternion.identity);
        }  
        if (hit.transform.name == "CubeSpawner") {  
          Instantiate(pref1, new Vector3(-4.5f, 1f, 6f), Quaternion.identity);
        }  
      }  
    }  
  }  
}   
