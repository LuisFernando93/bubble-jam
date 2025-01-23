using TMPro;
using UnityEngine;

public class Orders : MonoBehaviour
{
    private BubbleTea bubbleTeaOrder;
    [SerializeField] private GameObject orderCupDisplay;
    [SerializeField] private GameObject orderBaseDisplay;
    [SerializeField] private GameObject orderSyrupDisplay;
    [SerializeField] private GameObject orderBubbleDisplay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NewOrder();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NewOrder()
    {
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
                orderBaseDisplay.GetComponent<TextMeshProUGUI>().text = "�gua";
                break;
            case 1:
                baseType = BaseType.Milk;
                orderBaseDisplay.GetComponent<TextMeshProUGUI>().text = "Leite";
                break;
            case 2:
                baseType = BaseType.GreenTea;
                orderBaseDisplay.GetComponent<TextMeshProUGUI>().text = "Ch� Verde";
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
                orderSyrupDisplay.GetComponent<TextMeshProUGUI>().text = "Xarope de Lim�o";
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

    private void CheckOrder()
    {

    }

    public void CompleteOrder()
    {

    }
}