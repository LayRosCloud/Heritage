using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWood : MonoBehaviour
{
    private int wood;

    public Action<int> WoodIsChanged;
    
    public void AddWood(int wood)
    {
        this.wood += wood;
        WoodIsChanged?.Invoke(this.wood);
        
        Debug.Log($"Дерево: {this.wood}");
    }

    public void RemoveWood(int wood)
    {
        this.wood -= wood;
        WoodIsChanged?.Invoke(this.wood);
        
        Debug.Log($"Дерево: {this.wood}");
    }
}
