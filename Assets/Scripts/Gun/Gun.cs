using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Gun : ScriptableObject
{
    [field: SerializeField]
    public int Energy { get; private set; }

    [field: SerializeField]
    public Sprite GunSkin { get; private set; }

    [field: SerializeField]
    public Sprite BulletSkin { get; private set; }

    [field: SerializeField]
    public float ReloadTime { get; private set; }
}
