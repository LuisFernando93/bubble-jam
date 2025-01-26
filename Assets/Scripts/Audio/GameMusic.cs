using UnityEngine;

public class GameMusic : MonoBehaviour
{
    [SerializeField] private AudioClip musicClip;

    private void Start()
    {
        SoundManager.Instance.PlaySingleMusic(musicClip);
    }
}
