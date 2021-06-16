using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Muzzle : MonoBehaviour
{

}

public abstract class statistics
{
    
    //----Attachments--------
    public static bool hasSight;
    public static bool hasLaserFlash;
    public static bool hasStock;
    public static bool hasFrontGrip;
    public static bool hasMuzzle;
    public static bool hasSilencer;

    //----estatistics--------
    public int durability; // max durability 100 / min 0
    public int ergonomics; // max ergonomics 100 / min 0
    public int accuracy; // being 100 the best, max accuracy 100 / min 50
    public int recoil; // being the lower the better, max recoil 400 / min 20
    public int muzzleSpeed; //  being in metros/segundo, max muzzle speed 1100m/s / min 300m/s
    public float weight; // max 300kg / min 0.5kg

    //---carateristics---------
    
    public int fireRate; // shots per minute, max fire rate 1300 / min 30
    public string weaponCalliber;
    public string weaponName;
    


    

}
