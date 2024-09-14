using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice
{
    public int sides;
    public int rollValue;

    public Dice(int sides)
    {
        this.sides = sides;
    }

    public void Roll()
    {
        rollValue = UnityEngine.Random.Range(1, sides + 1);
    }
}

public class DiceRoll
{
    public Dice dice;
    public List<int> modifiers;

    public DiceRoll()
    {
        dice = new Dice(20);
        modifiers = new List<int>();
    }

    public void AddModifier(int modifier)
    {
        modifiers.Add(modifier);
    }

    public int Roll()
    {
        dice.Roll();

        int value = dice.rollValue;

        for (int i = 0; i < modifiers.Count; i++)
        {
            value += modifiers[i];
        }

        return value;

    }
}
