using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameManager currentState;
    

    // Start is called before the first frame update
    public void RandomOutcome()
    {
        currentState.RandomResult();
        currentState.ShowOutCome(currentState.RandomResult(), currentState.GreatSuccess, currentState.NormalSuccess,currentState.Failure);
    }
 
}
