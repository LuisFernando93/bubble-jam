using UnityEngine;
using UnityEngine.UI;

public class Cup : MonoBehaviour
{
    [SerializeField] private CupType cupType;
    [SerializeField] private GameObject mixer, orders;
    [SerializeField] private Sprite cupImage;

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
                orders.GetComponent<Orders>().CheckCup(this.cupType);
            } 
        }
    }
}
