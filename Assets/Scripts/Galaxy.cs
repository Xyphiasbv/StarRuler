using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy 
{
    // Start is called before the first frame update
    public Galaxy(){
        SolarSystems = new List<Celestial>();

    }

    public List<Celestial> SolarSystems;

    public void Generate(int numberOfStars){

    }

    public void LoadFromFile(string fileName){

    }
}
