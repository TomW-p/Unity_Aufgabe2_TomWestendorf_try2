using UnityEngine;

public class CoinManager : MonoBehaviour
{

    [SerializeField] private int coinCount = 0;
    [SerializeField] private UIManager uIManager;
    [SerializeField] private SceneController sceneController;

    [SerializeField] private int intMoneyGoal = 5;

    private void Start()
    {
        coinCount = 0;
        uIManager.UpdateCoinText(coinCount);
    }

    public void AddCoin()
    {
        coinCount++;
        
        uIManager.UpdateCoinText(coinCount);
    }

    public void Update()
    {
        if (coinCount == intMoneyGoal)
        {
            sceneController.WinGame();
        }
    }
    
}