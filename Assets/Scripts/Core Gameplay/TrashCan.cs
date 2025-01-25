using UnityEngine;

public class TrashCan : MonoBehaviour
{
    [SerializeField] private GameObject mixer;

    public void OnClick()
    {
        if (mixer != null)
        {
            Mixer mixerScript = mixer.GetComponent<Mixer>();
            if (mixerScript.bubbleTea != null)
            {
                mixerScript.bubbleTea = null;
                mixer.SetActive(false);
                Debug.Log("Para de desperdicar ingrediente >:I");
            }
            
            
        }
    }
}
