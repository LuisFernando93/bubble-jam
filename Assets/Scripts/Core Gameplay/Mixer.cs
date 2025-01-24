using System;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    [HideInInspector] public BubbleTea bubbleTea = null;
    [SerializeField] private GameObject orders;

    public void OnClick()
    {
        if (bubbleTea != null)
        {
            if (!bubbleTea.hasBase)
            {
                Debug.Log("Você ainda não escolheu uma base :(");
            }
            if (!bubbleTea.hasSyrup)
            {
                Debug.Log("Está faltando o xarope :(");
            }
            if (!bubbleTea.hasBubble)
            {
                Debug.Log("Deixou de colocar o principal! O Bubble! >:(");
            }

            if (bubbleTea.hasBase & bubbleTea.hasSyrup & bubbleTea.hasBubble)
            {
                Debug.Log("Saindo um Bubble Tea de " + bubbleTea.baseType + " com " + bubbleTea.syrup + " e bubbles " + bubbleTea.bubble + " no copo " + bubbleTea.cup + " :3");
                orders.GetComponent<Orders>().CompleteOrder(bubbleTea);
                bubbleTea = null;
            }

        } else
        {
            Debug.Log("Nenhum copo foi selecionado ainda :(");
        }
    }
}
