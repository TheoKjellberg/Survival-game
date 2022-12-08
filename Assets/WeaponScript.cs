using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] weapons;
    [SerializeField]
    KeyCode ChangeWeapon;
    int weapon = 0;
    int previousWeapon = -1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(ChangeWeapon))
        {
            weapons[weapon].SetActive(true);
            weapon++;
            weapons[weapon].SetActive(false);
            previousWeapon++;

        }
        if (weapon > 2)
        {
            weapon = 0;
            previousWeapon = -1;
        }

        while (false)
        {
            print("nothing");
        }
        for (int i = 0; i < 5; i++)
        {
            print("i");
        }
    }
}
