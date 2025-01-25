using System;
using TMPro;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    [HideInInspector] public BubbleTea bubbleTea = null;
    [SerializeField] private GameObject orders;
    [SerializeField] private GameObject mixServe;
    [SerializeField] private GameObject baseOrder, syrupOrder, bubbleOrder;

    public void OnClick()
    {
        if (bubbleTea != null)
        {
            if (!bubbleTea.hasBase)
            {
                Debug.Log("Você ainda não escolheu uma base :(");
                baseOrder.GetComponent<TextMeshProUGUI>().color = Color.red;
            } else baseOrder.GetComponent<TextMeshProUGUI>().color = Color.black;
            if (!bubbleTea.hasSyrup)
            {
                Debug.Log("Está faltando o xarope :(");
                syrupOrder.GetComponent<TextMeshProUGUI>().color = Color.red;
            } else syrupOrder.GetComponent<TextMeshProUGUI>().color = Color.black;
            if (!bubbleTea.hasBubble)
            {
                Debug.Log("Deixou de colocar o principal! O Bubble! >:(");
                bubbleOrder.GetComponent<TextMeshProUGUI>().color = Color.red;
            } else bubbleOrder.GetComponent<TextMeshProUGUI>().color = Color.black;

            if (bubbleTea.hasBase & bubbleTea.hasSyrup & bubbleTea.hasBubble)
            {
                Debug.Log("Saindo um Bubble Tea de " + bubbleTea.baseType + " com " + bubbleTea.syrup + " e bubbles " + bubbleTea.bubble + " no copo " + bubbleTea.cup + " :3");
                orders.GetComponent<Orders>().CompleteOrder(bubbleTea);
                bubbleTea = null;
                mixServe.SetActive(false);
            }

        } else
        {
            Debug.Log("Nenhum copo foi selecionado ainda :(");
        }
    }
}
