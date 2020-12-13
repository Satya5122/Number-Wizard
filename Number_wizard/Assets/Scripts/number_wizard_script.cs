using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class number_wizard_script : MonoBehaviour
{
    public int max;
    public int min;
    public int guess;
    // Start is called before the first frame update
    void Start()
    {
        startgame();
    }
    void startgame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard, Let me guess it.......");
        Debug.Log("Pick a Number");
        Debug.Log("Highest number is : " + max);
        Debug.Log("Lowest number is : " + min);
        Debug.Log("Now i'll try to guess the number.If higher than the guess press Uparrow or if lower than the guess press Downarrow or if the guess is correct press space");
        Debug.Log("is your number :" + guess);
        max = max + 1;
    }
    void guessing()
    {
        guess = (min + max) / 2;
        Debug.Log("is your number :" + guess);
    }
    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            min = guess;
            guessing();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           
            max = guess;
            guessing();

        }
        else if(Input.GetKeyDown(KeyCode.Space))
                {
            Debug.Log("Thats it i guessed your number");
            startgame();
        }
        
    }
}
