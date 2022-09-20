using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyView : MonoBehaviour
{
    GameController gameController;
    public GameObject solarSystemObject;    
    public List<SolarSystem> solarSystems;
    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
        showGalaxy();   
    }

    public void showGalaxy(){

        while(transform.childCount > 0){
            Transform c = transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }

        solarSystems = gameController.galaxy.SolarSystems;
        foreach(SolarSystem solarSystem in solarSystems){
            GameObject newSolarSystem = Instantiate(solarSystemObject, solarSystem.Position, Quaternion.identity) as GameObject;
            newSolarSystem.transform.SetParent(this.transform);
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
