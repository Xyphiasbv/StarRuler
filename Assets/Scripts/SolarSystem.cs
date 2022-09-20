using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : Celestial
{
    public SolarSystem(){
        Planets = new List<Planet>();

    }
    public List<Planet> Planets;
    
    public void Generate(){
        Celestial newStar = new Celestial();
        celestialDistance = Random.Range(30,40);
        flatAngle = Random.Range(0,2*Mathf.PI);
        heightAngle = Random.Range(0,2*Mathf.PI);
        this.AddChild(newStar);

        for(int i = 0; i < 3; i++){
            Planet planet = new Planet();
            planet.Generate();
            newStar.AddChild(planet);
            Planets.Add(planet);
        }

    }

    public void LoadFromFile(string fileName){

    }
    public void SaveToFile(){
        
    }

    
}
