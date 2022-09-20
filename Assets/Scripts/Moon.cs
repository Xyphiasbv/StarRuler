using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : Celestial
{
    public Moon(){

    }

    public void Generate(){
        celestialDistance = 1;
        flatAngle = Random.Range(0,Mathf.PI*2);
    }
}
