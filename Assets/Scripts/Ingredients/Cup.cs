using UnityEngine;
using UnityEngine.UI;

public class Cup : MonoBehaviour
{
    [SerializeField] private CupType cupType;
    [SerializeField] private GameObject mixer;
    [SerializeField] private Sprite cupImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (mixer != null)
        {
            Mixer mixerScript = mixer.GetComponent<Mixer>();
            if (mixerScript.bubbleTea == null)
            {
                mixerScript.bubbleTea = new BubbleTea(this.cupType);
                mixer.SetActive(true);
                mixer.GetComponent<Image>().sprite = cupImage;
                mixer.GetComponent<Image>().SetNativeSize();
            } 
        }
    }
}
