using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisastersManager : MonoBehaviour
{
    [SerializeField] List<Disaster> disasters;
    Disasters disaster;
    public float timerLimit = 0;
    float Timer = 0;
    
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
        int d = Random.Range(0, disasters.Capacity);

        switch (d)
        {
            case 0:
                //Disasters.Tornato();
                break;
            case 1:
                Disasters.Shark_tornados();
                break;
            case 2:
                Disasters.Earthquake();
                break;
            case 3:
                Disasters.Tsunami();
                break;
            case 4:
                Disasters.Aliens();
                break;
            case 5:
                Disasters.War();
                break;
            case 6:
                Disasters.Rabbis();
                break;
            case 7:
                Disasters.Pandemic();
                break;
            case 8:
                Disasters.Ice_Age();
                break;
            case 9:
                Disasters.Mass_food_poisoning();
                break;
            case 10:
                Disasters.Godzilla();
                break;
            case 11:
                Disasters.Giant_spriked_hail();
                break;
            case 12:
                Disasters.Rogue_Rugby_Players();
                break;
            case 13:
                Disasters.Falling_Shy();
                break;
        }

    }
}
