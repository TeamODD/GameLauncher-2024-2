using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace UIEffect
{
    public class ButtonAction : MonoBehaviour
    {
        [SerializeField] Image childImage;
        [SerializeField] TextMeshProUGUI text;
        Image image;

        void Awake()
        {
            image = GetComponent<Image>();
            text = GetComponent<TextMeshProUGUI>();
        }



        void setAlpha(Image i, float a)
        {
            Color c = i.color;
            c.a = a;
            i.color = c;
        }

        void setAlpha(TextMeshProUGUI text, float a)
        {
            Color c = text.color;
            c.a = a;
            text.color = c;
        }
    }
}