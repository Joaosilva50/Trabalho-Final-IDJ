using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 class Weapon : statistics
{

    //weight(0.5kg-300kg)durability(0-100), ergonomics(0-100), accuracy(50-100), recoil(20-400), muzzle speed(300-1100), fire rate(30-1300), weapon calliber, weapon name
    public Weapon(float weigh, int dura, int ergo, int accu, int reco, int muzzleSp, int fireRt, string weaponCal, string weaponNm)
    {

        if (dura < 0 || dura > 100)
        {
            dura = 100;
        }

        if (ergo < 0)
        {
            ergo = 0;
        }
        else if (ergo > 100)
        {
            ergo = 100;
        }

        if (accu < 40)
        {
            accu = 40;
        }
        else if (accu > 100)
        {
            accu = 100;
        }

        if (reco < 20)
        {
            reco = 20;
        }
        else if (reco > 400)
        {
            reco = 400;
        }

        if (muzzleSp < 200)
        {
            muzzleSp = 200;
        }
        else if (muzzleSp > 1700)
        {
            muzzleSp = 1700;
        }
        

        if(weigh< 0.5)
        {
            weigh = 0.5f;
        }
        else if(weigh > 1000)
        {
            weigh = 1000;
        }

        if(fireRt< 10)
        {
            fireRt = 10;
        }else if(fireRt > 10000)
        {
            fireRt = 10000;
        }

        this.weaponCalliber = weaponCal;
        this.weight = weigh;
        this.durability = dura;
        this.ergonomics = ergo;
        this.accuracy = accu;
        this.recoil = reco;
        this.muzzleSpeed = muzzleSp;
        this.fireRate = fireRt;
        this.weaponName = weaponNm;
        
    }

    public void GetStats() // Comunicates weapon stats to visual variables in game
    {
        Text WeaponName = GameObject.Find("Canvas/Weapon name").GetComponent<Text>();
        WeaponName.text = weaponName;

        Text WeaponCalliber = GameObject.Find("Canvas/Calliber var").GetComponent<Text>();
        WeaponCalliber.text = weaponCalliber;

        Text weaponFireRate = GameObject.Find("Canvas/Fire rate var").GetComponent<Text>();
        weaponFireRate.text = fireRate.ToString() + " " + "rounds/min";


        Text Durability = GameObject.Find("Canvas/Durability var").GetComponent<Text>();
        Durability.text = durability.ToString() + " / 100";

        Text Ergonomics = GameObject.Find("Canvas/Ergonomics var").GetComponent<Text>();
        Ergonomics.text = ergonomics.ToString() + " / 100";

        Text Accuracy = GameObject.Find("Canvas/Accuracy var").GetComponent<Text>();
        Accuracy.text = accuracy.ToString();

        Text Recoil = GameObject.Find("Canvas/Recoil var").GetComponent<Text>();
        Recoil.text = recoil.ToString();

        Text MuzzleSpeed = GameObject.Find("Canvas/MuzzleSpeed var").GetComponent<Text>();
        MuzzleSpeed.text = muzzleSpeed.ToString()+ " m/s";

        Text WeaponWeight = GameObject.Find("Canvas/Weight var").GetComponent<Text>();
        WeaponWeight.text = weight.ToString() + " KG";
    }


    //ADD ATTACHMENTS
    public void AddSilencer()
    {
        if(hasSilencer == false && hasMuzzle == false)
        {
            weight += 0.5f;
            recoil = recoil - (recoil * 10 / 100);
            ergonomics -= 14;
            muzzleSpeed += 1;
            hasSilencer = true;
            hasMuzzle = false;
        }
    }

    public void AddSight()
    {
        if(hasSight == false)
        {
            weight += 0.255f;
            ergonomics -= 2;
            hasSight = true;
        }
    }

    public void AddLaserFlash()
    {
        if(hasLaserFlash == false)
        {
            weight += 0.21f;
            ergonomics -= 1;
            hasLaserFlash = true;
        }
    }

    public void AddStock()
    {
        if(hasStock == false)
        {
            weight += 0.23f;
            recoil = recoil - (recoil * 30/100);
            ergonomics += 8;
            hasStock = true;
        }
    }

    public void AddFrontGrip()
    {
        if(hasFrontGrip == false)
        {
            weight += 0.17f;
            recoil = recoil - (recoil * 3 / 100);
            ergonomics += 1;
            hasFrontGrip = true;
        }
    }

    public void AddMuzzle()
    {
        if(hasMuzzle == false && hasSilencer == false)
        {
            weight += 0.125f;
            recoil = recoil - (recoil * 14 / 100);
            ergonomics -= 1;
            accuracy = accuracy + (accuracy * 3 / 100);
            muzzleSpeed += 1;
            hasMuzzle = true;
            hasSilencer = false;
        }
    }


    //REMOVE ATTACHMENTS
    public void RemoveSilencer()
    {
        if (hasSilencer == true)
        {
            weight -= 0.5f;
            recoil = recoil + (recoil * 10 / 100);
            ergonomics += 14;
            muzzleSpeed -= 1;
            hasSilencer = false;
        }
    }

    public void RemoveSight()
    {
        if (hasSight == true)
        {
            weight -= 0.255f;
            ergonomics += 2;
            hasSight = false;
        }
    }

    public void RemoveLaserFlash()
    {
        if (hasLaserFlash == true)
        {
            weight -= 0.21f;
            ergonomics += 1;
            hasLaserFlash = false;
        }
    }

    public void RemoveStock()
    {
        if (hasStock == true)
        {
            weight -= 0.23f;
            recoil = recoil + (recoil * 30 / 100);
            ergonomics -= 8;
            hasStock = false;
        }
    }

    public void RemoveFrontGrip()
    {
        if (hasFrontGrip == true)
        {
            weight -= 0.17f;
            recoil = recoil + (recoil * 3 / 100);
            ergonomics -= 1;
            hasFrontGrip = false;
        }
    }

    public void RemoveMuzzle()
    {
        if (hasMuzzle == true)
        {
            weight -= 0.125f;
            recoil = recoil + (recoil * 14 / 100);
            ergonomics += 1;
            accuracy = accuracy - (accuracy * 3 / 100);
            muzzleSpeed -= 1;
            hasMuzzle = false;
        }
    }

    
}
