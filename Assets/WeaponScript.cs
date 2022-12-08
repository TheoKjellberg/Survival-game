using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : PlayerShootScript
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject[] weapons;
    [SerializeField]
    KeyCode ChangeWeapon;
    int weapon = 0;
    int previousWeapon = -1;
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(ChangeWeapon))
        {
            print(weapon);
            weapons[0].SetActive(true);
            weapon++;

            weapons[previousWeapon].SetActive(false);
            previousWeapon++;

        }
        if (weapon >= weapons.Length)
        {
            weapon = 0;
            previousWeapon = -1;
        }

        while (false)
        {
            print("nothing");
        }
        for (int i = 0; i < 0; i++)
        {
            print("i");
        }
    }
}
