using UnityEngine;

public class CoinManager : MonoBehaviour
{

    [SerializeField] private int coinCount = 0;
    [SerializeField] private UIManager uIManager;

    private void Start()
    {
        coinCount = 0;
        //uIManager.UpdateCoinText(coinCount);
    }

    public void AddCoin()
    {
        coinCount++;
        
        //uIManager.UpdateCoinText(coinCount);
    }
    
}