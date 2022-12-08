using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolScript : WeaponScript
{
    // Start is called before the first frame update
    [SerializeField]
    KeyCode reload;
    int bulletCount;
    public override void Start()
    {
        base.Start();
        shootDelay = 0.4f;
        bulletCount = 6;
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        if (shot >= bulletCount)
        {
            canShoot = false;
        }
        if (Input.GetKey(reload))
        {
            shot = 0;
            canShoot = true;
        }
    }
}
