using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    [SerializeField] private TMP_Text coinCountText;
    [SerializeField] private GameObject panelLost;
    [SerializeField] Button retryButton;

    void Start()
    {
        panelLost.SetActive(false);
        retryButton.onClick.AddListener(ReloadLevel);
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ShowPanelLost()
    {
        panelLost.SetActive(true);
    }
    
    public void UpdateCoinText(int newCoinCount)
    {
        coinCountText.text = newCoinCount.ToString();
    }
}