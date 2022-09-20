using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : Celestial
{
    public Planet(){

    }

    public void Generate(){
        celestialDistance = Random.Range(5,11);
        flatAngle = Random.Range(0,Mathf.PI*2);
        Moon newMoon = new Moon();
        newMoon.Generate();  
        this.AddChild(newMoon);
              
    }


}
