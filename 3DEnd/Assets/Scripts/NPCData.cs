using UnityEngine;

[CreateAssetMenuAttribute(fileName = "NPC資料",menuName = "Vinenia/NPC資料")]

public class NPCData : ScriptableObject
{
    [Header("第一段對話"), TextArea(1,3)]
    public string dialogA;
    [Header("第二段對話"), TextArea(1,3)]
    public string dialogB;
    [Header("第三段對話"), TextArea(1,3)]
    public string dialogC;
    [Header("任務項目需求數量")]
    public int count;
    [Header("已經取得項目數量")]
    public int countCurrent;
}
