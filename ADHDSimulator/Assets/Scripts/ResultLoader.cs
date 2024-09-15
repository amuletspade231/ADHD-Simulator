using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultLoader : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        switch (RollEvent.result)
        {
            case 0: text.text = "You overslept and almost missed your first meeting... and definitely missed breakfast. Did you take your meds already?";
                break;
            case 1: text.text = "Success! Eyes - opened. Meds - taken. Breakfast - made. You are ready to take on the world.";
                break;
            case 2: text.text = "Success? You made the best breakfast of your life and you look and feel like a boss... until your boss reminded you to join the meeting you're now 5 mins late to.";
                break;
            default:
                text.text = "Oh. This is a zero spoons day, huh? Just call in sick buddy.";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
