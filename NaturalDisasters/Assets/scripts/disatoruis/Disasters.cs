using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disasters : MonoBehaviour
{
    // public population_growth pop;
    public float catagory;
    public  void Tornato()
    {
        print("Toronto");
        GetComponent<population_growth>().Tornoto(catagory);
        // Population decrease
        // City damage

    }

    public  void Shark_tornados()
    {
       
        
        print("Shark_tornados");
        GetComponent<population_growth>().SharTornoto();
        //Population decrease
        // City damage
    }

    public  void Earthquake()
    {
        print("Earthquake");
        GetComponent<population_growth>().EarthQuake(catagory);
        
        // City damage
        //Population decrease
    }

    public  void Tsunami()
    {
        print("Tsunami");
        // City damage
        //Population decrease
    }

    public void Aliens()
    {
        print("Aliens");
        // City damage
        //Population decrease
    }
    public  void War()
    {
        print("War");
        // City damage
        //Warrier Population decrease
    }
    public void Rabbis()
    {
        print("Rabbis");
        //Population decrease
    }
    public  void Pandemic()
    {
        print("Pandemic");
        //Population decrease
    }

    public  void Ice_Age()
    {
        print("Ice_Age");
        //Population decrease
    }
    public  void Mass_food_poisoning()
    {
        print("Mass_food_poisoning");
        //Population decrease
    }
    public  void Godzilla()
    {
        print("Godzilla");
        //Population decrease
        // City damage
    }
    public  void Giant_spriked_hail()
    {
        print("Toronto");
        //Population decrease
    }
    public  void Rogue_Rugby_Players()
    {
        print("Giant_spriked_hail");
        //Population decrease
    }

    public  void Falling_Shy()
    {
        print("Falling_Shy");
        //Population decrease
        // City damage
    }
}
