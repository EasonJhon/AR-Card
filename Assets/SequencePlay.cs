using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequencePlay : MonoBehaviour
{
    public int Index;
    public AudioClip[] Clips;
    public AudioSource AS;
    
    public Sprite[] Sprites;
    public Image Img;
    
    public string[] Strings;
    public Text Txt;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClick()
    {
        if (AS.isPlaying)
        {
            AS.Stop();
        }

        Index++;
        if (Index >= Sprites.Length)
        {
            Index = 0;
        }

        Img.sprite = Sprites[Index];
        Img.SetNativeSize();
        if (Img.GetComponent<RectTransform>().rect.height >= 1700)
        {
            Img.GetComponent<RectTransform>().localScale =
                new Vector3(1, 1700 / Img.GetComponent<RectTransform>().rect.height, 1);
        }
        else
        {
            Img.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
        Txt.text = Strings[Index];
        AS.clip = Clips[Index];
        AS.Play();
    }

    public void OnFound()
    {
        Index = 0;
        Img.sprite = Sprites[Index];
        Img.SetNativeSize();
        if (Img.GetComponent<RectTransform>().rect.height >= 1700)
        {
            Img.GetComponent<RectTransform>().localScale =
                new Vector3(1, 1700 / Img.GetComponent<RectTransform>().rect.height, 1);
        }
        else
        {
            Img.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
        Txt.text = Strings[Index];
        AS.clip = Clips[Index];
        AS.Play();
    }

    public void OnLost()
    {
        AS.Stop();
    }
}