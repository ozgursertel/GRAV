using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ScoreScrpt : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score;
    public static ScoreScrpt Instance;

    public void Update()
    {
        score.text = player.position.x.ToString();
    }
}
