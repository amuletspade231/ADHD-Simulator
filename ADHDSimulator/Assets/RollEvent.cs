using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RollEvent : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    DiceRoll diceRoll;

    // Start is called before the first frame update
    void Start()
    {
        diceRoll = new DiceRoll();
    }

    public void Roll()
    {
        UpdateText();
    }

    private void UpdateText()
    {
        text.text = diceRoll.Roll().ToString();
    }
}
