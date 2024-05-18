using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [field: SerializeField]
    public float speed { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move towards the player
        transform.position = Vector2.MoveTowards(transform.position, Player.Instance.transform.position, speed * Time.deltaTime);
    }

    private float originalSpeed;
    public void StopMoving()
    {
        originalSpeed = speed;
        speed = 0;
    }

    public void ContinueMoving()
    {
        speed = originalSpeed;
    }

    public void KillSelf()
    {
        Destroy(this.gameObject);
    }
}
