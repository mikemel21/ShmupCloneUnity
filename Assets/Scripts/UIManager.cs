using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text scoretext;

    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "Score: " + 0;
    }

    public void UpdateScore (int playerScore) {
        scoretext.text = "Score: " + playerScore.ToString();
    }
}
