using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDTerminalDots : MonoBehaviour
{
    [SerializeField] MechanismManager mechanismManager;
    [SerializeField] TerminalData hubTerminal;

    [SerializeField] List<TerminalData> terminal = new List<TerminalData>();

    [SerializeField] List<Sprite> dot1Sprites = new List<Sprite>();
    [SerializeField] List<Sprite> dot2Sprites = new List<Sprite>();
    [SerializeField] List<Sprite> dot3Sprites = new List<Sprite>();

    [SerializeField] Image dot1Image;
    [SerializeField] Image dot2Image;
    [SerializeField] Image dot3Image;

    [SerializeField] TMP_Text dot1Text;
    [SerializeField] TMP_Text dot2Text;
    [SerializeField] TMP_Text dot3Text;

    [SerializeField] bool isSign;

    void Update()
    {
        if (mechanismManager.oxygenFilteringDraw > 0 && terminal[0].activeCells.Count > 0)
        {
            if (hubTerminal.cellBatteryAmount[terminal[0].activeCells[0]] < (mechanismManager.shipPowerTotal / hubTerminal.batteryCellCount) / 2)
            {
                dot1Image.sprite = dot1Sprites[2];

                if (isSign)
                {
                    dot1Text.text = "half empty";
                }
            }
            else
            {
                dot1Image.sprite = dot1Sprites[1];

                if (isSign)
                {
                    dot1Text.text = "Connected";
                }
            }
        }
        else
        {
            dot1Image.sprite = dot1Sprites[0];

            if (isSign)
            {
                dot1Text.text = "Unconnected";
            }
        }

        if (mechanismManager.sheildDraw > 0 && terminal[1].activeCells.Count > 0)
        {
            if (hubTerminal.cellBatteryAmount[terminal[1].activeCells[0]] < (mechanismManager.shipPowerTotal / hubTerminal.batteryCellCount) / 2)
            {
                dot2Image.sprite = dot2Sprites[2];

                if (isSign)
                {
                    dot2Text.text = "half empty";
                }
            }
            else
            {
                dot2Image.sprite = dot2Sprites[1];

                if (isSign)
                {
                    dot2Text.text = "Connected";
                }
            }
        }
        else
        {
            dot2Image.sprite = dot2Sprites[0];

            if (isSign)
            {
                dot2Text.text = "Unconnected";
            }
        }

        if (mechanismManager.experimentDraw > 0 && terminal[2].activeCells.Count > 0)
        {
            if (hubTerminal.cellBatteryAmount[terminal[2].activeCells[0]] < (mechanismManager.shipPowerTotal / hubTerminal.batteryCellCount) / 2)
            {
                dot3Image.sprite = dot3Sprites[2];

                if (isSign)
                {
                    dot3Text.text = "half empty";
                }
            }
            else
            {
                dot3Image.sprite = dot3Sprites[1];

                if (isSign)
                {
                    dot3Text.text = "Connected";
                }
            }
        }
        else
        {
            dot3Image.sprite = dot3Sprites[0];

            if (isSign)
            {
                dot3Text.text = "Unconnected";
            }
        }
    }
}
