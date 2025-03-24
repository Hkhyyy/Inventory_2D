using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private TextMeshProUGUI criText;
    [SerializeField] private Button backButton;
    
    private void Start()
    {
        backButton.onClick.AddListener(() => UIManager.Instance.MainMenu.OpenMainMenu());
    }

    public void UpdateStatus(Character character)
    {
        hpText.text = $"{character.HP}";
        attackText.text = $"{character.ATK}";
        defenseText.text = $"{character.DEF}";
        criText.text = $"{character.CRI}";
    }
}