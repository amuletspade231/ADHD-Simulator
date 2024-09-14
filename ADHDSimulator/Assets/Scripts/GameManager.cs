using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //The continue button is used to advance the game state and bring new options for the player. You can delay the apperance of the button with a coroutine
    public GameObject continueButton;
    //The following panels are show the outcome of option. Given how the game works and how the code is set up...
    //You'll need three of these variables for every option in the game, so be prepared for a big inspector
    
    //Case in point. Look at all those variables!
    public GameObject startScreen;
    public GameObject wakeUpScene;
    public GameObject wakeUpGreat;
    public GameObject wakeUpNormal;
    public GameObject wakeUpFail;
    public GameObject foodScene;
    public GameObject foodGreat;
    public GameObject foodNormal;
    public GameObject foodFail;
    public GameObject workScene;
    public GameObject workGreat;
    public GameObject workNormal;
    public GameObject workFail;
    public GameObject endScreen;
    //The game state is just that, the current state of the game and how we can control the pacing
    public int gameState;
    // Start is called before the first frame update
    private void Start()
    {
        //When starting, we will need all of the uneccessary panels to be off, so that we can turn then on at the righ time.
        startScreen.SetActive(true);
        wakeUpScene.SetActive(false);
        foodScene.SetActive(false);
        workScene.SetActive(false);
        continueButton.SetActive(false);
        endScreen.SetActive(false);
    }

    private void Update()
    {
        if(gameState == 0)
        {
            startScreen.SetActive(true);
            wakeUpScene.SetActive(false);
            foodScene.SetActive(false);
            workScene.SetActive(false);
            endScreen.SetActive(false);
        }

        if(gameState == 1)
        {
            startScreen.SetActive(false);
            wakeUpScene.SetActive(true);
        }

        if(gameState == 2)
        {
            wakeUpScene.SetActive(false);
            foodScene.SetActive(true);
        }

        if (gameState == 3)
        {
            foodScene.SetActive(false);
            workScene.SetActive(true);
        }

        if (gameState == 4)
        {
            workScene.SetActive(false);
            endScreen.SetActive(true);
        }
    }
    public int RandomResult()
    {
        //Randome Results just returns a number between 1 and 6. The main mechanic of our game
        int result = Random.Range(1, 6);
        return result;
    }

    public void ShowOutCome(int result, GameObject GreatSuccess, GameObject NormalSuccess, GameObject Failure)
    {
        //Show OutCome display to our player the result of the option, and then shows the continue button afterwards.
        if (result >= 5)
        {
            GreatSuccess.SetActive(true);
            NormalSuccess.SetActive(false);
            Failure.SetActive(false);
        }

        if(result<=4 && result >= 3)
        {
            GreatSuccess.SetActive(false);
            NormalSuccess.SetActive(true);
            Failure.SetActive(false);
        }

        if (result <= 2)
        {
            GreatSuccess.SetActive(false);
            NormalSuccess.SetActive(false);
            Failure.SetActive(true);
        }

        continueButton.SetActive(true);
    }
}
