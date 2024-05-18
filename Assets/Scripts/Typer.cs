using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    // Characters to be typed
    public string word = null;

    // Start is called before the first frame update
    private void Start()
    {
        SetCurrentWord();
    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();
    }

    private void SetCurrentWord()
    {
        // string wordsBank = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        string wordsBank = "abcdefghijklmnopqrstuvwxyz";
        word = wordsBank[Random.Range(0, wordsBank.Length)].ToString();

        Debug.Log(word);
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
            SetCurrentWord();
        }
    }

    private bool IsCorrectLetter()
    {
        return Input.inputString == word;
    }
}
