using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player { get; private set; }

    [SerializeField] private UIManager uiManager;
    [SerializeField] private List<Sprite> testInventorySprites; // 인스펙터에서 테스트용 아이템 연결 가능

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        // 테스트용 캐릭터 생성
        Player = new Character("플레이어1", 100, 25, 10, 5, testInventorySprites);

        // UI에 캐릭터 정보 세팅
        uiManager.StatusUI.UpdateStatus(Player);
        uiManager.InventoryUI.UpdateInventory(Player);
    }
}