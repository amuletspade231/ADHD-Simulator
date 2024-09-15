using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.TimeZoneInfo;

public enum alphaValue
{
    SHRINKING,
    GROWING
}

public class TextFlicker : MonoBehaviour
{
    public TextMeshProUGUI text;
    public alphaValue currAlphaValue;
    public float CommentMinAlpha;
    public float CommentMaxAlpha;
    public float CommentCurrAlpha;


    // Start is called before the first frame update
    void Start()
    {
        CommentMinAlpha = 0.1f;
        CommentMaxAlpha = 1f;
        CommentCurrAlpha = 1f;
        currAlphaValue = alphaValue.SHRINKING;
}

    // Update is called once per frame
    void Update()
    {
        AlphaComments();
    }

    public void AlphaComments()
    {
        if(currAlphaValue == alphaValue.SHRINKING)
        {
            CommentCurrAlpha = CommentCurrAlpha - 0.003f;
            text.color = new Color(Color.black.r, Color.black.g, Color.black.b, CommentCurrAlpha);
            if (CommentCurrAlpha <= CommentMinAlpha )
            {
                currAlphaValue = alphaValue.GROWING;
            }
        }
        else if (currAlphaValue == alphaValue.GROWING)
        {
            CommentCurrAlpha = CommentCurrAlpha + 0.003f;
            text.color = new Color(Color.black.r, Color.black.g, Color.black.b, CommentCurrAlpha);
            if (CommentCurrAlpha >= CommentMaxAlpha)
            {
                currAlphaValue = alphaValue.SHRINKING;
            }
        }
    }
}
