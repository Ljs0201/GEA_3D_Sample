using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    // 요구사항 필드 선언
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;
    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Settle()
    {
        // 1. 플레이 시간
        int hours = playSeconds / 3600;
        int minutes = (playSeconds % 3600) / 60;
        int seconds = playSeconds % 60;

        string minStr = (minutes < 10 ? "0" : "") + minutes;
        string secStr = (seconds < 10 ? "0" : "") + seconds;
        string timeStr = hours + ":" + minStr + ":" + secStr;

        Debug.Log("플레이 시간 " + timeStr);

        // 2. 골드 분배
        int goldPerMember = gold / members;
        int leaderBonusGold = gold % members;

        Debug.Log("1인당 " + goldPerMember + "G, 리더 보너스 " + leaderBonusGold + "G");

        // 3. 경험치
        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);

        Debug.Log("경험치 " + finalExp + " (기본 " + baseExp + ")");

        // 4. 레벨 및 다음 레벨까지 남은 경험치
        int level = 1 + (finalExp / 100);
        int remainExp = 100 - (finalExp % 100);

        Debug.Log("Lv " + level + ", 다음 레벨까지 " + remainExp);

        // 5. 평균 데미지
        float avgDamage = (float)totalDamage / hits;
    
        Debug.Log("평균 데미지 " + avgDamage);
    }
}