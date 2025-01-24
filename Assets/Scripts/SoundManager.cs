using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    [SerializeField] private AudioSource _musicSource, _effectsSource;
    [SerializeField] private AudioMixer _mixer;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        _effectsSource.PlayOneShot(clip);
    }

    public void PlaySingleMusic(AudioClip clip)
    {
        _musicSource.clip = clip;
        _musicSource.Play();
    }
    
    public void ChangeMasterVolume(float value)
    {
        _mixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
    }

    public void ChangeMusicVolume(float value)
    {
        _mixer.SetFloat("VolumeMusic", Mathf.Log10(value) * 20);
    }

    public void ChangeSFXVolume(float value)
    {
        _mixer.SetFloat("VolumeSFX", Mathf.Log10(value) * 20);
    }
}
