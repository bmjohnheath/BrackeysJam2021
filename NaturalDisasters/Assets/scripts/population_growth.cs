﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class population_growth : MonoBehaviour
{

    public float populationGrowth;
    public float popincrease;
    public float pop;
    public float foodsupply;
   // public float research;
  //  public float reaCooldown;
    public float foodcooldown;
     float maxfoodcooldown;
    public float FoodAllocuation;
    public float researchers;
    public float fooddecrease;
    public float foodincrease;
    public float unemployed;
    public float farmers;
    public float researchPoints;

    void Start()
    {
        unemployed = pop;
        maxfoodcooldown = 60;
        foodcooldown = maxfoodcooldown;
        
    }

    // Update is called once per frame
    void Update()
    {

        researchPoints += researchers * Time.deltaTime;        
        //  popincrease = popincrease - (foodsupply / 2);
        foodcooldown -= farmers *Time.deltaTime;

       //populationGrowth += popincrease * Time.deltaTime + food * Time.deltaTime;
        populationGrowth -= popincrease  * Time.deltaTime;


        //reaCooldown = +researchallocution * Time.deltaTime;
        if (populationGrowth <= 0)
        {
            CityGetBigger();
        }
        if(foodcooldown <= 0)
        {
            foodStorageChange();
        }
        if(foodsupply <=0)
        {
            foodsupply = 0;
        }
        if(pop == 100)
        {

        }
    }


    public void CityGetBigger()
    {
        pop += foodsupply;
        unemployed += foodsupply;
        populationGrowth = 1000;
        if(foodsupply >= 0)
        {
            Debug.Log("city got bigger");


        }
        if(foodsupply <= -1)
        {
            Debug.Log("city got smaller");
        }
        if(pop <= -1)
        {
            Debug.Log("game over");
        }
    }
    public void foodStorageChange()
    {
        //foodcooldown = 100;
        if(foodsupply >= pop)
        {
            // CityGetBigger()

            foodsupply += 1+ pop;
            foodcooldown = 100;
        }
        if(foodsupply < pop)
        {
            fooddecrease = Random.Range(0, 8);
            foodincrease = Random.Range(0, 12);
            foodsupply -= fooddecrease;
            foodsupply += foodincrease;
            foodcooldown = 100;
        }
        
    }
    public void workinfamr()
    {
        FoodAllocuation++;
        if(unemployed <= pop && unemployed != 0)
        {
            farmers++;
            unemployed--;
        }
        

        
    }
     public void CreatSceinces()
    {
        if (unemployed <= pop && unemployed != 0)
        {
           researchers++;
            unemployed--;
        }
    }
}