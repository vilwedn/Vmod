using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
public class mouse: MonoBehaviour {  
     public GameObject pref;
  void Start() {}  
  
  // Update is called once per frame    
  void Update() {  
    if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) {  
        //Select stage    
        if (hit.transform.name == "Cube") {  
          Instantiate(pref, new Vector3(3f, 0.7f, -2.4f), Quaternion.identity);
        }  
      }  
    }  
  }  
}   
