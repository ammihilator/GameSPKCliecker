using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEnemy : MonoBehaviour
{
    public Text ScoreText;

    public  int coreScore = 0;

    public void ClickOnEnemy()
    {
        coreScore++;
        ScoreText.text = coreScore.ToString();
    }
}
