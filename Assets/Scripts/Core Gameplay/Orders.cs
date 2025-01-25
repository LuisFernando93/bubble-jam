using TMPro;
using UnityEngine;

public class Orders : MonoBehaviour
{
    private BubbleTea bubbleTeaOrder;
    private int currentPoints;
    [SerializeField] private int scorePoints = 10;
    [SerializeField] private int bonusTime = 2;
    [SerializeField] private int penaltyTime = 1;
    [SerializeField] private GameObject orderCupDisplay;
    [SerializeField] private GameObject orderBaseDisplay;
    [SerializeField] private GameObject orderSyrupDisplay;
    [SerializeField] private GameObject orderBubbleDisplay;
    [SerializeField] private GameObject scoreTracker;
    [SerializeField] private GameObject timer;
    [SerializeField] private GameObject cupOrder, baseOrder, syrupOrder, bubbleOrder;
    [SerializeField] private AudioClip _correctOrderSFX, _wrongOrderSFX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NewOrder();
    }

    private void NewOrder()
    {
        cupOrder.GetComponent<TextMeshProUGUI>().color = Color.black;
        baseOrder.GetComponent<TextMeshProUGUI>().color = Color.black;
        syrupOrder.GetComponent<TextMeshProUGUI>().color = Color.black;
        bubbleOrder.GetComponent<TextMeshProUGUI>().color = Color.black;
        currentPoints = scorePoints;
        CupType cup;
        BaseType baseType;
        SyrupType syrup;
        BubbleType bubble;

        int rng = Random.Range(0, 3);
        switch (rng)
        {
            case 0:
                cup = CupType.Small;
                orderCupDisplay.GetComponent<TextMeshProUGUI>().text = "Copo pequeno";
                break;
            case 1:
                cup = CupType.Medium;
                orderCupDisplay.GetComponent<TextMeshProUGUI>().text = "Copo medio";
                break;
            case 2:
                cup = CupType.Large;
                orderCupDisplay.GetComponent<TextMeshProUGUI>().text = "Copo grande";
                break;
            default:
                cup = CupType.Null;
                orderCupDisplay.GetComponent<TextMeshProUGUI>().text = "ERRO";
                break;
        }

        rng = Random.Range(0, 3);
        switch (rng)
        {
            case 0:
                baseType = BaseType.Water;
                orderBaseDisplay.GetComponent<TextMeshProUGUI>().text = "Água";
                break;
            case 1:
                baseType = BaseType.Milk;
                orderBaseDisplay.GetComponent<TextMeshProUGUI>().text = "Leite";
                break;
            case 2:
                baseType = BaseType.GreenTea;
                orderBaseDisplay.GetComponent<TextMeshProUGUI>().text = "Chá Verde";
                break;
            default:
                baseType = BaseType.Null;
                orderBaseDisplay.GetComponent<TextMeshProUGUI>().text = "ERRO";
                break;
        }

        rng = Random.Range(0, 3);
        switch (rng)
        {
            case 0:
                syrup = SyrupType.Blueberry;
                orderSyrupDisplay.GetComponent<TextMeshProUGUI>().text = "Xarope de Blueberry";
                break;
            case 1:
                syrup = SyrupType.Lemon;
                orderSyrupDisplay.GetComponent<TextMeshProUGUI>().text = "Xarope de Limão";
                break;
            case 2:
                syrup = SyrupType.Strawberry;
                orderSyrupDisplay.GetComponent<TextMeshProUGUI>().text = "Xarope de Morango";
                break;
            default:
                syrup = SyrupType.Null;
                orderSyrupDisplay.GetComponent<TextMeshProUGUI>().text = "ERRO";
                break;
        }

        rng = Random.Range(0, 3);
        switch (rng)
        {
            case 0:
                bubble = BubbleType.Boba;
                orderBubbleDisplay.GetComponent<TextMeshProUGUI>().text = "Bubble Boba";
                break;
            case 1:
                bubble = BubbleType.FruityMix;
                orderBubbleDisplay.GetComponent<TextMeshProUGUI>().text = "Bubble Fruity Mix";
                break;
            case 2:
                bubble = BubbleType.CrazyJam;
                orderBubbleDisplay.GetComponent<TextMeshProUGUI>().text = "Bubble Crazy Jam";
                break;
            default:
                bubble = BubbleType.Null;
                orderBubbleDisplay.GetComponent<TextMeshProUGUI>().text = "ERRO";
                break;
        }

        bubbleTeaOrder = new BubbleTea(cup, baseType, syrup, bubble);
    }

    private bool OrderIsCorrect(BubbleTea bubbleTea)
    {
        if (bubbleTea.cup == bubbleTeaOrder.cup & bubbleTea.baseType == bubbleTeaOrder.baseType & bubbleTea.syrup == bubbleTeaOrder.syrup & bubbleTea.bubble == bubbleTeaOrder.bubble)
        {
            return true;
        }
        else return false;
    }

    public void CompleteOrder(BubbleTea bubbleTea)
    {
        if (OrderIsCorrect(bubbleTea))
        {
            SoundManager.Instance.PlaySFX(_correctOrderSFX);
            scoreTracker.GetComponent<ScoreTracker>().AddScore(scorePoints);
            timer.GetComponent<Timer>().AddTime(bonusTime);
            Debug.Log("Pedido correto :3");
            NewOrder();
        } else
        {
            SoundManager.Instance.PlaySFX(_wrongOrderSFX);
            timer.GetComponent<Timer>().ReduceTime(penaltyTime);
            Debug.Log("Pedido errado :(");
        }
    }
}
