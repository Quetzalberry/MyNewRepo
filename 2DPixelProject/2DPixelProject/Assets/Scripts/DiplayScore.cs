using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiplayScore : MonoBehaviour
{
    public static Score scoreScript;

    public TMP_Text textbox;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        textbox.text = "Score: " + counter.ToString();
    }

    public void increasePoints(int x)
    {
        counter += x;
        textbox.text = "Score: " + counter.ToString();
    }
}
