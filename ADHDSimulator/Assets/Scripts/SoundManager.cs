using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }
}
