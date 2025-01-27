using UnityEngine;

public class TrashCan : MonoBehaviour
{
    [SerializeField] private GameObject _mixer;
    [SerializeField] private AudioClip _trashClick;
    [SerializeField] private GameObject orders;

    public void OnClick()
    {
        if (_mixer != null)
        {
            Mixer mixerScript = _mixer.GetComponent<Mixer>();
            if (mixerScript.bubbleTea != null)
            {
                SoundManager.Instance.PlaySFX(_trashClick);
                mixerScript.bubbleTea = null;
                _mixer.SetActive(false);
                Debug.Log("Para de desperdicar ingrediente >:I");
            }
            orders.GetComponent<Orders>().SetLabelsToDefault();
            
        }
    }
}
