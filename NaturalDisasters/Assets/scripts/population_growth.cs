using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class population_growth : MonoBehaviour
{
  //public bool largepop;
  //public   bool hugepop;
    //public  bool smallpop; 
    [Header("population")]
    public float populationGrowth;
    public float populationcooldown;
    public float popincrease;
    public float pop;
    public float unemployed;
    public float populationboom;
    public float populationdecrease;
    public float chance;
    [Header("food")]
    public float foodsupply;
   // public float research;
  //  public float reaCooldown;
    public float foodcooldown;
   public  float maxfoodcooldown;
   // public float FoodAllocuation;
   
    public float fooddecrease;
    public float foodincrease;
  
    public float farmers;


    [Header("sickness &doctor & education")]
    public float sickness;
    public float sicknessdecrease;
    public float sicknessstart;
    public float Medical;
    public float education;
    public float researchPoints;
    public float educated;
    public float deathfromsickness;
    public float deathFromsicknessmultiplyer;
    [Header("miltary & defense")]
    public float miltary;
    public float defense;
    public float DamagedDefense;
    [Header("diastours")]
    public bool diasatouri = false;
    public bool tornado = false;
    public bool SharkTornodo = false;
    public bool Earthquake =false;
   // public float catogory;
    public GameObject DisasterControler;
    public bool diasasterinprogress;
    public float disatormeter;
    //public float disatortimer;
    public float disatorreduction;
    //  public float maxfloat; 

    void Start()
    {
        unemployed = pop;
        maxfoodcooldown = 60;
        foodcooldown = maxfoodcooldown;
        populationGrowth = populationcooldown;
        sickness = sicknessstart;

        DisasterControler = GameObject.FindGameObjectWithTag("Disaster");
    }

    // Update is called once per frame
    void Update()
    {
        //sicknessdecrease =  
        researchPoints += 10*Time.deltaTime + education * Time.deltaTime;
        defense = (miltary * 10) - DamagedDefense;
        foodcooldown -= farmers *Time.deltaTime;
        unemployed = pop - farmers - education - Medical -miltary-educated;
       
        populationGrowth -= popincrease  * Time.deltaTime;
        sickness -= sicknessdecrease * Time.deltaTime;
     
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
        if(unemployed <= 0)
        {
            unemployed = 0;
        }
        if(sickness <= 0)
        {
            sickness = sicknessstart;
            deathfromtheflu();
        }
        if(diasasterinprogress == true)
        {
           
            if(tornado == true)
            {
                populationdieing(1);
            }
            if(SharkTornodo == true)
            {
               //isatormeter = 100;
                populationdieing(3);
            }
            if(Earthquake == true)
            {
                earthquakedefese(3);
            }
            
            
            
            disatormeter -= disatorreduction*Time.deltaTime;
           
        }


        if (disatormeter <= 0)
        {
            Debug.Log("is triggering");
            DisasterControler.GetComponent<DisastersManager>().disatercanHappen = true;
            if (tornado == true)
            {
                tornado = false;
            }
            if(SharkTornodo == true)
            {
                SharkTornodo = false;
            }
            if(Earthquake == true)
            {
                Earthquake = false;
            }
            diasasterinprogress = false;
            disatormeter = 100;
        }

    }


    public void deathfromtheflu()
    {
        //deathfromsickness = Random.RandomRange(1, 11);
        deathfromsickness = Random.Range(1, 11);
        pop -= deathfromsickness * deathFromsicknessmultiplyer-Medical;
        checklosecondtion();

    }


    public void CityGetBigger()
    {
        pop += popincrease;
        // unemployed += foodsupply;
        //


        if (foodsupply >= pop)
        {

            populationcooldown--;
            populationGrowth = populationcooldown;
            populationcooldown--;
            foodsupply -= pop;

            pop += 20;
            // babyboom();
            if (populationcooldown <= 0)
            {
                populationcooldown = 100;
            }


            chance = Random.Range(0, 6);
            if (chance == 4)
            {
                babyboom();
            }

        }
        else
        {
            foodsupply -= pop;
            populationGrowth++;
            populationGrowth = populationcooldown;
            populationGrowth++;
            fooddecrease = Random.Range(0, 100);

            pop -= fooddecrease;
            famine();
            checklosecondtion();

        }

    } 
        
        
      public void Tornoto(float catogory)
      {

        DisasterControler.GetComponent<DisastersManager>().disatercanHappen = false;
        catogory = Random.Range(0, 6);
        
        if(catogory == 1)
        {
            disatormeter = 30;
            tornado = true;
        }
        if (catogory == 2)
        {
            disatormeter = 60;
            tornado = true;
        }
        if (catogory == 3)
        {
            disatormeter = 90;
            tornado = true;
        }
        if (catogory == 4)
        {
            disatormeter = 180;
            tornado = true;
        }
        if (catogory == 5)
        {
            disatormeter = 250;
            tornado = true;
        }
        diasasterinprogress = true;

      }  
        


    public void SharTornoto()
    {
        disatormeter = 100;

        DisasterControler.GetComponent<DisastersManager>().disatercanHappen = false;
       
        diasasterinprogress = true;
    }


    public void EarthQuake(float catogory)
    {

        DisasterControler.GetComponent<DisastersManager>().disatercanHappen = false;
        catogory = Random.Range(0, 6);

        if (catogory == 1)
        {
            disatormeter = 10;
            Earthquake = true;
        }
        if (catogory == 2)
        {
            disatormeter = 25;
            Earthquake = true;
        }
        if (catogory == 3)
        {
            disatormeter = 40;
            Earthquake = true;
        }
        if (catogory == 4)
        {
            disatormeter = 60;
            Earthquake = true;
        }
        if (catogory == 5)
        {
            disatormeter = 90;
            Earthquake = true;
        }
        diasasterinprogress = true;
    }


   public void earthquakedefese(float lowerdefense)
    {
      
        if(defense >= 0)
        {
            defense -= lowerdefense * Time.deltaTime;
        }
        if(defense <= 0)
        {
            populationdieing(lowerdefense + 3);
        }
    }
    
    public void populationdieing(float deaths)
       {
        pop -= deaths*Time.deltaTime;
       } 
        
       public void repairdefense()
    {

    } 
   
         
    public  void babyboom()
    {
        populationboom = Random.Range(0, pop);
        pop += populationboom;
    }
    public void foodStorageChange()
    {
      

            foodsupply += 30;
            foodcooldown = maxfoodcooldown ;
        maxfoodcooldown++;
      
        
    }
    public void workinfamr()
    {
      //  FoodAllocuation++;
        if(unemployed <= pop && unemployed != 0)
        {
         
            
        
            
                farmers++;
           
           
        }
        

        
    }
    public void fireFarmer()
    {

        if (farmers > 0)
        {
            farmers--;
          //  unemployed++;
        }
        else
        {
           // Debug.Log("no farmers");
        }



    }
    public void CreatSceinces()
    {
        if (unemployed <= pop && unemployed != 0 )
        {
           education++;
            researchPoints -= 50;
           // educated += 1;
            
          //  unemployed--;
        }
    }
    public void createeducated()
    {
        if( researchPoints >= 50)
        {
            educated += 1;
            researchPoints -= 50;
        }
    }
    public void fireresearcher()
    {

       
        if(education > 0)
        {
                education--;
          //  unemployed++;
        }
        else
        {
            Debug.Log("no farmers");
        }
    }
    public void hiredoctors() {
        if (educated >=1 && unemployed <= pop && unemployed != 0)
        
        {
            
            Medical++;
            educated--;
        
        
        
        }
          
    
    
    }
    public void fireDoctors()
    {
      //  Medical--;
    }
    public void miltaryincrease()
    {
        if (unemployed <= pop && unemployed != 0)
        {
          miltary++;
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
        checklosecondtion();
    }
}
