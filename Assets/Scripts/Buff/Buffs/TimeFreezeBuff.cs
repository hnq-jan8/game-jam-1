using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeFreezeBuff : AbstractBuff
{
    [SerializeField]
    private UnityEvent OnFreezeTime;

    [SerializeField]
    private UnityEvent OnUnfreezeTime;

    [SerializeField]
    private float freezeTime;

    private Enemy[] enemies;

    public override void DoBuff()
    {
        enemies = FindObjectsOfType<Enemy>();

        StartCoroutine(BeginTimeFreeze());
    }

    private IEnumerator BeginTimeFreeze()
    {
        FreezeTime();

        yield return new WaitForSecondsRealtime(freezeTime);

        UnfreezeTime();
    }

    private void FreezeTime()
    {
        OnFreezeTime.Invoke();
        foreach(Enemy e in enemies)
        {
            //Stop enemies from moving (there should be a function in Enemy script that allows this)
            e.StopMoving();
        }
    }

    private void UnfreezeTime()
    {
        OnUnfreezeTime.Invoke();
        foreach (Enemy e in enemies)
        {
            //Enable enemies to move (there should be a function in Enemy script that allows this)
            e.ContinueMoving();
        }
    }
}
