using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        float scale = Screen.height / 1080.0f;
        rectTransform.localScale = new Vector3(scale, scale);

        Vector3 position = rectTransform.anchoredPosition;
        position.x *= scale;
        position.y *= scale;

        rectTransform.anchoredPosition = position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
