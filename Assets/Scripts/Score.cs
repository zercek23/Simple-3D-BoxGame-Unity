using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        float tempPosition = -player.position.x;
        tempPosition = tempPosition + 10;
        ScoreText.text = tempPosition.ToString("0");
    }
}
