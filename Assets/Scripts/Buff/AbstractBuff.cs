using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class AbstractBuff : ScriptableObject
{
    public abstract void DoBuff(MonoBehaviour caller);
}