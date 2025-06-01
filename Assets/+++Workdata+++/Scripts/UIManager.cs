using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text coinCountText;
    public void UpdateCoinText(int newCoinCount)
    {
        coinCountText.text = newCoinCount.ToString();
    }
}