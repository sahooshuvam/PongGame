using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public int score1;
    public int score2;
    public Text score1Text;
    public Text score2Text;

    public void Score1Calculator(int scoreValue)
    {
        score1 = score1 + scoreValue;
        score1Text.text = score1.ToString();
    }

    public void Score2Calculator(int scoreValue)
    {
        score2 = score2 + scoreValue;
        score2Text.text = score2.ToString();
    }


}
