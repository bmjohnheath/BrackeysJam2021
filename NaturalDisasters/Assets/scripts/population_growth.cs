using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class population_growth : MonoBehaviour
{
  //public bool largepop;
  //public   bool hugepop;
    //public  bool smallpop; 
    public float populationGrowth;
    public float populationcooldown;
    public float popincrease;
    public float pop;
    public float foodsupply;
   // public float research;
  //  public float reaCooldown;
    public float foodcooldown;
   public  float maxfoodcooldown;
    public float FoodAllocuation;
    public float researchers;
    public float fooddecrease;
    public float foodincrease;
    public float unemployed;
    public float farmers;
    public float researchPoints;
    public float populationboom;
    public float populationdecrease;
    public float chance;
  //  public float maxfloat; 

    void Start()
    {
        unemployed = pop;
        maxfoodcooldown = 60;
        foodcooldown = maxfoodcooldown;
        populationGrowth = populationcooldown;
        
    }

    // Update is called once per frame
    void Update()
    {

        researchPoints += researchers * Time.deltaTime;        
        //  popincrease = popincrease - (foodsupply / 2);
        foodcooldown -= farmers *Time.deltaTime;
        unemployed = pop - farmers - researchers;
       //populationGrowth += popincrease * Time.deltaTime + food * Time.deltaTime;
        populationGrowth -= popincrease  * Time.deltaTime;
      //  maxfloat = researchers + farmers + unemployed;

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
      //  popullationcontrol();
     // if(farmers <=0)
        //{
           // farmers = 0;
        //}

      //if(researchers<= 0)
        //{
            //researchers = 0;
        //}
    }


 


    public void CityGetBigger()
    {
        pop += popincrease;
       // unemployed += foodsupply;
       //
       

        if (foodsupply == pop)
        {

           // populationcooldown++;
            populationGrowth = populationcooldown;
            populationcooldown++;
            foodsupply -= pop;

            pop += 20;
            // babyboom();
            chance = Random.Range(0, 6);
            if(chance == 4)
            {
                babyboom();
            }

        }
        else
        {
            foodsupply -= pop;
           // populationGrowth--;
            populationGrowth = populationcooldown;
            populationGrowth--;
            fooddecrease = Random.Range(0, 100);

            pop -= fooddecrease;
            checklosecondtion();

        }
        
        
        
        
        
        
        
        
        
        
        //if(foodsupply >= 0)
        //{
        //    Debug.Log("city got bigger");


        //}
        //if(foodsupply <= -1)
        //{
        //    Debug.Log("city got smaller");
        //}
        
    }
    public  void babyboom()
    {
        populationboom = Random.Range(0, 50);
        pop += populationboom;
    }
    public void foodStorageChange()
    {
        //foodcooldown = 100;
       // if(foodsupply >= pop)
        //{
            // CityGetBigger()

            foodsupply += 30;
            foodcooldown = maxfoodcooldown ;
        maxfoodcooldown++;
        //}
        //if(foodsupply < pop)
        //{
            //fooddecrease = Random.Range(0, 8);
            //foodincrease = Random.Range(0, 12);
            //foodsupply -= fooddecrease;
            //foodsupply += foodincrease;
            //foodcooldown = 100;
        //}
        
    }
    public void workinfamr()
    {
        FoodAllocuation++;
        if(unemployed <= pop && unemployed != 0)
        {
         
            
          //  if(maxfloat <= pop)
            
                farmers++;
                unemployed--;
                Debug.Log("yourer hired");
            
           
        }
        

        
    }
    public void fireFarmer()
    {

        if (farmers > 0)
        {
            farmers--;
            unemployed++;
        }
        else
        {
            Debug.Log("no farmers");
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
    public void fireresearcher()
    {

       
        if(researchers > 0)
        {
            researchers--;
            unemployed++;
        }
        else
        {
            Debug.Log("no farmers");
        }
    }

    public void checklosecondtion()
    {
       if(pop <= 0)
        {
            Debug.Log("you lose game over");
        }
    }
    public void famine()
    {
        populationdecrease = Random.Range(0, pop);
        pop -= populationdecrease;
    }
}
