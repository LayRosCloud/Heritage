using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    [SerializeField] private Image[] images;
    [SerializeField] private Button[] buttons;

    private void ShowShop(List<Item> items)
    {
        gameObject.SetActive(true);
    }

    public void SetItemsUI(List<Item> items, float discount)
    {
        ShowButtons();
        
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == null)
            {
                images[i].enabled = false;
                buttons[i].gameObject.SetActive(false);
                continue;
            }

            images[i].sprite = items[i].image;
            images[i].enabled = true;
            buttons[i].GetComponentInChildren<TextMeshProUGUI>().text = $"{Math.Ceiling(items[i].price - (items[i].price * (discount/100.0)))} золота";
        }
        
        ShowShop(items);
    }

    private void ShowButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(true);
        }
    }

    public void DeleteItemUI(int index)
    { 
        images[index].enabled = false;
        buttons[index].gameObject.SetActive(false);
    }
}