using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    public float speed = 1.0f;

    // Character to be typed
    [SerializeField]
    public string word = "word";

    private string remainingWord = null;

    // Start is called before the first frame update
    void Start()
    {
        remainingWord = word;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    public void Kill()
    {
        Destroy(gameObject);
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
                Kill();
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
}
