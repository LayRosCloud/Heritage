using UnityEngine;

[RequireComponent(typeof(PlayerStats), typeof(Wallet))]
public class Player : MonoBehaviour
{
    public PlayerStats PlayerStats { get; private set; }
    public Wallet Wallet { get; private set; }
    
    public Inventory Inventory { get; private set; }

    private void Awake()
    {
        Application.targetFrameRate = 60;
        PlayerStats = GetComponent<PlayerStats>();
        PlayerStats.Init();

        Wallet = GetComponent<Wallet>();

        Inventory = GetComponent<Inventory>();
    }
}
