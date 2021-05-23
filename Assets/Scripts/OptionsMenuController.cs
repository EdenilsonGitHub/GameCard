using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuController : MonoBehaviour
{
    public Toggle toggleSoundSFX;
    public Toggle toggleSoundMusic;
    public Slider sliderVolumeSFX;
    public Slider sliderVolumeMusic;

    void Start() {
        toggleSoundSFX.isOn = ApplicationControler.IsMuttedSoundSFX ();
        toggleSoundMusic.isOn = ApplicationControler.IsMuttedSoundMusic ();
        sliderVolumeSFX.value = ApplicationControler.GetVolumeSFX ();
        sliderVolumeMusic.value = ApplicationControler.GetVolumeMusic ();
    }

    void Update()
    {
        
    }
}
