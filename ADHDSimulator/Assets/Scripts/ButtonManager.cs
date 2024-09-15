using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    //Button Manager provides functions that will be needed for our buttons, mainly two, Randon Outcome and Advance GameState
    [SerializeField] GameManager currentState;

    // Start is called before the first frame update
    public void RandomOutcomeWakeUp()
    {
        //This function gets the random result from RandomResult and gives the appropriate outcome
        //As I mentioned in Game Manager, we're gonna need a outcome for all options for the game PER state.
        //This means button manager will functions like RandomeOutComeWork1, RandomeOutComeWork2, etc.
        //All of these functions work the same, but need different panels for them. I'll probably have a basic skeleton of the game by the time you see this
        currentState.RandomResult();
        currentState.ShowOutCome(RollEvent.result, currentState.wakeUpGreat, currentState.wakeUpNormal,currentState.wakeUpFail);
    }

    public void RandomOutcomeFood()
    {
        currentState.RandomResult();
        currentState.ShowOutCome(RollEvent.result, currentState.foodGreat, currentState.foodNormal, currentState.foodFail);
    }

    public void RandomOutcomeWork()
    {
        currentState.RandomResult();
        currentState.ShowOutCome(RollEvent.result, currentState.workGreat, currentState.workNormal, currentState.workFail);
    }

    public void AdvanceGameState()
    {
        //When advancing the state, we disable all panels and increase the game state by 1 (which is what will replace the debug.log here.
        //To avoid having more variables then necessary, we can tuck all of the options and outcome panels in one empty (so a Work object would have all of the options
        //and outcomes associated with work) Once we're done with it, we can disable just that object and also disable everything beneath it.
        
        Debug.Log("Game State advanced");

        //So apparently if you reenable an object, the current result will also reenable. tbh, I'm not making advance game state functions per panel as this
        //feels very tedious anyways, so I'm gonna disable them all at once.
        //I'm sure there's a far better way to do this, I just haven't figure it out yet.
        currentState.gameState += 1;
        currentState.continueButton.SetActive(false);
        currentState.wakeUpGreat.SetActive(false);
        currentState.wakeUpNormal.SetActive(false);
        currentState.wakeUpFail.SetActive(false);
        currentState.foodGreat.SetActive(false);
        currentState.foodNormal.SetActive(false);
        currentState.foodFail.SetActive(false);
        currentState.workGreat.SetActive(false);
        currentState.workNormal.SetActive(false);
        currentState.workFail.SetActive(false);
    }

    public void EndGame()
    {
        currentState.gameState = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
 
}
