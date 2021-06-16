using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class MainScript : MonoBehaviour
{
    //weight(0.5kg-300kg)durability(0-100), ergonomics(0-100), accuracy(50-100), recoil(20-400), muzzle speed(300-1100), fire rate(30-1300), weapon calliber, weapon name
    Weapon w = new Weapon(3.2f, 100, 55, 70, 65, 900, 600, "5.56mm", "M4A1");

    Weapon w2 = new Weapon(2.9f, 100, 75, 70, 65, 900, 600, "5.56mm", "M4A2");

    Weapon w3 = new Weapon(1.5f, 70, 75, 70, 20, 200, 20, "explosive arrow", "Tactical bow");

    void Start()
    {

        //w.AddSight();
        w.GetStats();
        //w2.GetStats();
    }

     void Update()
    {
        //w.GetStats();
        
    }


   
    //button functions for visual representation
    public void Silencer()
    {
        w.AddSilencer();
        w.GetStats();
    }

    public void Stock()
    {
        w.AddStock();
        w.GetStats();

    }
    public void Sight()
    {
        w.AddSight();
        w.GetStats();
    }
    public void Muzzle()
    {
        w.AddMuzzle();
        w.GetStats();

    }
    public void FrontGrip()
    {
        w.AddFrontGrip();
        w.GetStats();
    }
    public void LaserFlash()
    {
        w.AddLaserFlash();
        w.GetStats();
    }

    public void RSilencer()
    {
        w.RemoveSilencer();
        w.GetStats();
    }

    public void RStock()
    {
        w.RemoveStock();
        w.GetStats();
    }
    public void RSight()
    {
        w.RemoveSight();
        w.GetStats();
    }
    public void RMuzzle()
    {
        w.RemoveMuzzle();
        w.GetStats();
    }
    public void RFrontGrip()
    {
        w.RemoveFrontGrip();
        w.GetStats();
    }
    public void RLaserFlash()
    {
        w.RemoveLaserFlash();
        w.GetStats();
    }

}
  