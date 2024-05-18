using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BuffType
{
    TIME_FREEZE,
    KILL_ALL,
}

public class BuffManager : MonoBehaviour
{
    public static BuffManager Instance { get; private set; }

    [SerializeField]
    private List<AbstractBuff> buffList = new List<AbstractBuff>();

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TriggerBuff(BuffType.KILL_ALL);
        }
    }

    public void TriggerBuff(BuffType type)
    {
        buffList[(int)type].DoBuff();
    }
}
