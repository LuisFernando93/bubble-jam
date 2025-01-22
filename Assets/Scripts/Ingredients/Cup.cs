using UnityEngine;

public class Cup : MonoBehaviour
{
    [SerializeField] private CupType cupType;
    [SerializeField] private GameObject mixer;

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
            } 
        }
    }
}
