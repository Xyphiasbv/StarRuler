using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celestial 
{    
    public Celestial parent;
    public List<Celestial> children;
    public int celestialDistance;
    public float flatAngle;
    public float heightAngle;
    public float currentAngle;
    public int timeToOrbit;    
    public Celestial(){
        children = new List<Celestial>();
        //flatAngle = Random.Range(0,2*Mathf.PI);
    }  

    public Vector3 Position{
        get{
            return new Vector3(
                Mathf.Sin(flatAngle+currentAngle)* celestialDistance,                
                Mathf.Sin(heightAngle)*celestialDistance,
                Mathf.Cos(flatAngle+currentAngle)* celestialDistance
            ); // return current position from planet.
        }
    }
    public void AddChild(Celestial c){
        c.parent = this;
        children.Add(c);
    }
    public void RemoveChild(Celestial c){
        c.parent = null;
        children.Remove(c);   
    }
    public void Update(int timeSinceStart) {
        //Advance angle in time
        currentAngle = (timeSinceStart/timeToOrbit)*2*Mathf.PI;

        for(int i = 0; i < children.Count; i++){
            children[i].Update(timeSinceStart);
        }
    }

}
