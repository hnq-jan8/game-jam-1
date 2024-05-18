using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    public string word = "word";

    private string remainingWord = null;
    
    [field: SerializeField]
    public float speed { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        remainingWord = word;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        
        // move towards the player
        transform.position = Vector2.MoveTowards(transform.position, Player.Instance.transform.position, speed * Time.deltaTime);
    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string input = Input.inputString;

            if (input.Length == 1)
            {
                TypeLetter();
            }
        }
    }

    private void TypeLetter()
    {
        // Kill the enemy if the letter is correct
        if (IsCorrectLetter())
        {
            word = word.Substring(1);

            if (IsWordTyped())
            {
                KillSelf();
                return;
            }

            Debug.Log("'" + word + "'");
        }
    }

    private bool IsCorrectLetter()
    {
        return word.StartsWith(Input.inputString);
    }

    private bool IsWordTyped()
    {
        return word.Length == 0;
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
