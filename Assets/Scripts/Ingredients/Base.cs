using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] private BaseType baseType;
    [SerializeField] private GameObject mixer, orders;

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
                if (!mixerScript.bubbleTea.hasBase)
                {
                    mixerScript.bubbleTea.AddBase(this.baseType);
                    orders.GetComponent<Orders>().CheckBase(this.baseType);
                }
            }
        }
    }
}
