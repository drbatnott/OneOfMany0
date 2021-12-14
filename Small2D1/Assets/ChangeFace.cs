using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFace : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        i = 0;
        spriteRenderer.sprite = sprites[i];
    }

    public void ChangeTheFace()
    {
        i++;
        if(i > sprites.Length - 1)
        {
            i = 0;
        }
        spriteRenderer.sprite = sprites[i];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
