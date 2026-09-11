using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class DiceRoll : MonoBehaviour
{
    int score = 0; // Initialize the score variable
    int randomNumber; // Variable to store the lucky number
    int diceRoll; // Variable to store the rolled number
    float timer = 20; // Variable to store the timer value
    bool isGameOver = false; // Variable to check if the game is over


    void RandomNumber()
    {
        randomNumber = Random.Range(1, 7); // Generates a random number between 1 and 6
    }


    void Start()
    {
        RandomNumber(); // Call the RandomNumber method to roll the dice at the start
        Debug.Log("Press the space key to roll the dice.");
        Debug.Log("If you roll the same number as the lucky number, you get a point!");
        Debug.Log("Your lucky number is: " + randomNumber);
        Debug.Log("Your current score is: " + score);
        Debug.Log("Good luck!");
    }

    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame && !isGameOver) // Check if the space key is pressed
        {
            RollDice(); // Call the RandomNumber method to roll the dice
        }

        Timer();

        if(timer <= 0 && !isGameOver)
        {
            timer = 0; // Ensure the timer doesn't go below 0
            isGameOver = true;
            Debug.Log("Time's up! Your final score is: " + score);
        }
    }

    void Timer()
    {
        timer -= Time.deltaTime; // Decrease the timer value by the time elapsed since the last frame
    }

    void RollDice()
    {
        diceRoll = Random.Range(1, 7); // Generates a random number between 1 and 6
        Debug.Log("You rolled a " + diceRoll);
        
        if (diceRoll == randomNumber)
        {
            score++;
            Debug.Log("You got a point! Your current score is: " + score);
        }
    }
}
