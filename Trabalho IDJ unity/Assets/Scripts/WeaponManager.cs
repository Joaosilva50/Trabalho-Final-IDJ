using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public GameObject Silencer;
    public GameObject muzzle; 
    public GameObject Laser; 
    public GameObject sight;
    public GameObject frontGrip; 
    public GameObject stock;
    public GameObject stock2; // deactivate for presentation purposes





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        models();
    }

    public void models() 
    {
      if(Weapon.hasFrontGrip == false)
        {
          frontGrip.SetActive(false);
        }
        else if (Weapon.hasFrontGrip == true)
            {
                frontGrip.SetActive(true);
            }
      if(Weapon.hasMuzzle == false)
        {
            muzzle.SetActive(false);
        }else if(Weapon.hasMuzzle == true)
        {
            Silencer.SetActive(false);
            muzzle.SetActive(true);
        }
        if (Weapon.hasLaserFlash == false)
        {
            Laser.SetActive(false);
        }
        else if (Weapon.hasLaserFlash == true)
        {
            Laser.SetActive(true);
        }

        if (Weapon.hasSilencer == false)
        {
            Silencer.SetActive(false);
        }
        else if (Weapon.hasSilencer == true)
        {
            Silencer.SetActive(true);
        }
        if (Weapon.hasSight == false)
        {
            sight.SetActive(false);
        }
        else if (Weapon.hasSight == true)
        {
            sight.SetActive(true);
        }

        if(Weapon.hasStock == false)
        {
            stock.SetActive(false);
            stock2.SetActive(true);
        }else if(Weapon.hasStock == true)
        {
            stock.SetActive(true);
            stock2.SetActive(false);
        }
    }



}
