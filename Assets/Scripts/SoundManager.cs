using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;
    public AudioClip switchSFX;

    public Slider BGMVolSilder;
    public Slider SFXVolSilder;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        BGMVolSilder.value = GameManager.Instance.bgmVol;
        SFXVolSilder.value = GameManager.Instance.sfxVol;
    }

    private void Update()
    {
        GameManager.Instance.bgmVol = BGMVolSilder.value;
        GameManager.Instance.sfxVol = SFXVolSilder.value;
        bgmAudioSource.volume = GameManager.Instance.bgmVol;
        sfxAudioSource.volume = GameManager.Instance.sfxVol;
    }

    public void SwitchEffect()
    {
        sfxAudioSource.PlayOneShot(switchSFX);
    }
}
