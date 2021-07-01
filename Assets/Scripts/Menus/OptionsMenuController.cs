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
        if (ApplicationControler.isFirstTime()){
            ApplicationControler.SetDefaultConfigs();
        }

        toggleSoundSFX.isOn = ApplicationControler.IsMuttedSoundSFX ();
        toggleSoundMusic.isOn = ApplicationControler.IsMuttedSoundMusic ();
        sliderVolumeSFX.value = ApplicationControler.GetVolumeSFX ();
        sliderVolumeMusic.value = ApplicationControler.GetVolumeMusic ();
    }

    void Update()
    {
        
    }

    public void SetSFXSound() {
        if (toggleSoundSFX.isOn)
            ApplicationControler.EnableSoundSFX ();
        else
            ApplicationControler.DisableSoundSFX ();
    }

    public void SetMusicSound() {
        if (toggleSoundMusic.isOn)
            ApplicationControler.EnableSoundMusic ();
        else
            ApplicationControler.DisableSoundMusic ();
    }

    public void SetVolumeSFX(){
        ApplicationControler.SetVolumeSFX (sliderVolumeSFX.value);
    }

    public void SetVolumeMusic(){
        ApplicationControler.SetVolumeMusic (sliderVolumeMusic.value);
    }
}
