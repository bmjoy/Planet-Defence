using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Lv1_LaserCtrl : TurretCtrl
{

    // Start is called before the first frame update
    private void Start()
    {
        m_bulletType = Bullet.Lv1_Laser;
        m_bulletPool = BulletPool.Turret;

        m_turretType = Turret.Lv1_Laser;

        m_blasterSound = AudioManager.eBulletSFX.LaserSFX;

        base.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
