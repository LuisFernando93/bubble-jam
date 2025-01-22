using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private BubbleType bubbleType;
    [SerializeField] private GameObject mixer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick()
    {
        if (mixer != null)
        {
            Mixer mixerScript = mixer.GetComponent<Mixer>();
            if (mixerScript.bubbleTea != null)
            {
                if (!mixerScript.bubbleTea.hasBubble)
                {
                    mixerScript.bubbleTea.AddBubble(this.bubbleType);
                }
            }
        }
    }
}
