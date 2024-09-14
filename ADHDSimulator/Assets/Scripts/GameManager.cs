using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GreatSuccess;
    public GameObject NormalSuccess;
    public GameObject Failure;
    // Start is called before the first frame update
    private void Start()
    {
        GreatSuccess.SetActive(false);
        NormalSuccess.SetActive(false);
        Failure.SetActive(false);
    }
    public int RandomResult()
    {
        int result = Random.Range(1, 10);
        return result;
    }

    public void ShowOutCome(int result, GameObject GreatSuccess, GameObject NormalSuccess, GameObject Failure)
    {
        if (result >= 8)
        {
            GreatSuccess.SetActive(true);
            NormalSuccess.SetActive(false);
            Failure.SetActive(false);
        }

        if(result<=7 && result >= 4)
        {
            GreatSuccess.SetActive(false);
            NormalSuccess.SetActive(true);
            Failure.SetActive(false);
        }

        if (result <= 3)
        {
            GreatSuccess.SetActive(false);
            NormalSuccess.SetActive(false);
            Failure.SetActive(true);
        }
    }
}
