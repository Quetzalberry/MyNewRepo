/*
* Denver Heneghan
* WinScript
* 2DPixelProject
* This script is attached to two tiles that are set as triggers. When these tile triggers come into contact with the object tagged as player, it activates the
* YouWin text to true. The text is set to hidden at the start of the game, so when it is set to true, the text will show up on screen.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScript : MonoBehaviour
{
    public TMP_Text WinText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            WinText.gameObject.SetActive(true);
        }
    }
}
