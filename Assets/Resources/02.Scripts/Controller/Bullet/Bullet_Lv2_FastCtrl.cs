using UnityEngine;
using System.Collections;

public class Bullet_Lv2_FastCtrl : BulletCtrl
{
    private void OnEnable()
    {
        BulletType = Bullet.Lv2_Fast;
        base.Init();
    }

    private void Update()
    {
        MoveToTarget();
    }
}
