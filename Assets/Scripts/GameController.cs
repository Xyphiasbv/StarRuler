using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable() {
        galaxy = new Galaxy();
        galaxy.Generate(10);
        
    }
    public Galaxy galaxy;

    // Update is called once per frame
    void Update()
    {
        
    }
}
