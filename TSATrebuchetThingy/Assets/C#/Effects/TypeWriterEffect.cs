using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{
    Text txt;
    string words;
    public float type_writer_speed;
    public float wait_to_write;

    void Awake()
    {
        txt = GetComponent<Text> ();
        words = txt.text;
        // grabs urer inputed text
        txt.text = "";
        
        // calls the next function
        StartCoroutine("TypeText");
    }

    IEnumerator TypeText()
    {
        yield return new WaitForSeconds (wait_to_write);
        foreach (char c in words)
        {
            txt.text += c;
            yield return new WaitForSeconds (type_writer_speed);
        }
    }
}
