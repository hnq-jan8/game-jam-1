using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Time Freeze Buff", menuName = "Buff/Time Freeze")]
public class TimeFreezeBuff : AbstractBuff
{
    [SerializeField]
    private float freezeTime;

    public override void DoBuff(MonoBehaviour caller)
    {
        caller.StartCoroutine(BeginTimeFreeze());
    }

    private IEnumerator BeginTimeFreeze()
    {
        Debug.LogError("A");
        FreezeTime();

        yield return new WaitForSecondsRealtime(freezeTime);

        UnfreezeTime();
    }

    private void FreezeTime()
    {
        Time.timeScale = 0f;
    }

    private void UnfreezeTime()
    {
        Time.timeScale = 1f;
    }
}
