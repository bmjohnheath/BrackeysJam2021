using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisastersManager : MonoBehaviour
{
    //[SerializeField] List<Disaster> disasters;
    //Disasters disaster;
    public float timerLimit = 0;
   public float Timer = 0;
    public GameObject population;



    public void Start()
    {
        population = GameObject.FindGameObjectWithTag("pop");
    }



    private void Update()
    {
        Timer += Time.deltaTime * 1;
        if (Timer >= timerLimit)
        {
            GenerateDisaster();
            Timer = 0;
        }
    }

    public void GenerateDisaster()
    {
        int d = Random.Range(0, 14);
       // population.GetComponent<Disasters>();
        switch (d)
        {
            case 0:
                //Disasters.Tornato();
                population.GetComponent<Disasters>().Tornato();
                break;
            case 1:

                  population.GetComponent<Disasters>().Shark_tornados();
                //  population.Disasters.Shark_tornados();
                break;
            case 2:
                population.GetComponent<Disasters>().Earthquake();

                // Disasters.Earthquake();

                break;
            case 3:

                population.GetComponent<Disasters>().Tsunami();
                //  Disasters.Tsunami();
                break;
            case 4:

                population.GetComponent<Disasters>().Aliens();
                //  Disasters.Aliens();
                break;
            case 5:

                population.GetComponent<Disasters>().War();
                //  Disasters.War();
                break;
            case 6:

                population.GetComponent<Disasters>().Rabbis();
                //  Disasters.Rabbis();
                break;
            case 7:

                population.GetComponent<Disasters>().Pandemic();
                // Disasters.Pandemic();
                break;
            case 8:

                population.GetComponent<Disasters>().Ice_Age();
                //  Disasters.Ice_Age();
                break;
            case 9:

                population.GetComponent<Disasters>().Mass_food_poisoning();
                //  Disasters.Mass_food_poisoning();
                break;
            case 10:

                population.GetComponent<Disasters>().Godzilla();
                //  Disasters.Godzilla();
                break;
            case 11:

                population.GetComponent<Disasters>().Giant_spriked_hail();
                //   Disasters.Giant_spriked_hail();
                break;
            case 12:
                population.GetComponent<Disasters>().Rogue_Rugby_Players();

                //  Disasters.Rogue_Rugby_Players();
                break;
            case 13:

                population.GetComponent<Disasters>().Falling_Shy();
                //  Disasters.Falling_Shy();
                break;
        }

    }
}
