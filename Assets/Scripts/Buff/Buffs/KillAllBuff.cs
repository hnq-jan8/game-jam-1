using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KillAllBuff : AbstractBuff
{
    [SerializeField]
    private UnityEvent OnKillAll;

    private Enemy[] enemies;

    public override void DoBuff()
    {
        enemies = FindObjectsOfType<Enemy>();

        KillAllEnemies();
    }

    private void KillAllEnemies()
    {
        OnKillAll.Invoke();
        foreach(Enemy e in enemies)
        {
            e.KillSelf();
        }
    }
}
