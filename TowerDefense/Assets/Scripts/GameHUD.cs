using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour
{
    public RawImage DiamondsIcon;
    public Text DiamondText;
    public RawImage LosesUnits;
    public Text LosesText;

    private GameMode gameMode;
    // Start is called before the first frame update
    void Start()
    {
        gameMode = transform.GetComponent<GameMode>(); // transform. означает что мы обращаемся к самому обьекту на котором висит скрипт
    }

    // Update is called once per frame
    void LateUpdate()
    {
        DiamondText.text = ""+ gameMode.Diamonds;
        LosesText.text = ""+ gameMode.LosesUnits;
    }
}
