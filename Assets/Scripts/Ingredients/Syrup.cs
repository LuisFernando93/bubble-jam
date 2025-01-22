using UnityEngine;

public class Syrup : MonoBehaviour
{
    [SerializeField] private SyrupType syrupType;
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
            if (mixerScript.bubbleTea != null)
            {
                if (!mixerScript.bubbleTea.hasSyrup)
                {
                    mixerScript.bubbleTea.AddSyrup(this.syrupType);
                }
            }
        }
    }
}
