using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RollEvent : MonoBehaviour
{
    public TextMeshProUGUI text;

    public static int result;

    public static bool rollDone = false;

    DiceRoll diceRoll;

    // Start is called before the first frame update
    void Start()
    {
        diceRoll = new DiceRoll();
    }

    public void Roll()
    {
        UpdateText();

        rollDone = true;
    }

    private void UpdateText()
    {
        text.text = diceRoll.Roll().ToString();

        if (diceRoll.dice.rollValue == 20)
        {
            result = 2; // crit success
        }
        else if (diceRoll.dice.rollValue < 10)
        {
            result = 0; // fail
        }
        else
        {
            result = 1; // success
        }
    }
}
