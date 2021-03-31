using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public GameObject leftbarrel, rightbarrel;
    public GameObject[] bullet;
    int bulletID;
    // Start is called before the first frame update
    void Start()
    {
        bulletID = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //OVRInput.Update();
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) == true)
        {
            FireLeftGun();
        }

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) == true)
        {
            FireRightGun();
        }
    }

    private void FixedUpdate()
    {
        //OVRInput.FixedUpdate();
    }

    void FireLeftGun()
    {
        bullet[bulletID].transform.position = leftbarrel.transform.position;
        bullet[bulletID].transform.rotation = leftbarrel.transform.rotation;
        bullet[bulletID].SetActive(true);
        bulletID += 1;

        if (bulletID >= bullet.Length)
        {
            bulletID = 0;
        }
    }

    void FireRightGun()
    {
        bullet[bulletID].transform.position = rightbarrel.transform.position;
        bullet[bulletID].transform.rotation = rightbarrel.transform.rotation;
        bullet[bulletID].SetActive(true);
        bulletID += 1;

        if (bulletID >= bullet.Length)
        {
            bulletID = 0;
        }
    }
}
