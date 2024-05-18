using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    [SerializeField]
    private List<Gun> gunList;

    private int currentGunIndex;

    [SerializeField]
    private int currentEnergy;

    [SerializeField]
    private int gunReloadCountDown;

    [SerializeField]
    private

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        currentEnergy = gunList[0].Energy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradeGun()
    {
        if (currentGunIndex >= gunList.Count) return;

        currentGunIndex++;

        currentEnergy = gunList[currentGunIndex].Energy;
        //Should also change gun skin and gun bullet skin
    }

    public void UseEnergy()
    {
        currentEnergy--;
    }

    public void ReloadGun()
    {
        StartCoroutine(ReloadCountdown(gunList[currentGunIndex].ReloadTime));
    }

    private IEnumerator ReloadCountdown(float reloadTime)
    {
        yield return new WaitForSeconds(reloadTime);

        currentEnergy = gunList[currentGunIndex].Energy;
    }
}
