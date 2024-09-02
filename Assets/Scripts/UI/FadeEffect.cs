using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace UIEffect
{
    public class FadeEffect : MonoBehaviour
    {
        [SerializeField] Image image;

        public IEnumerator FadeIn()
        {
            float a = 1, t, speed = 2f;
            image.gameObject.SetActive(true);

            setAlpha(image, a);
            while (0 < a)
            {
                t = Time.deltaTime;
                setAlpha(image, speed * t);
                yield return new WaitForSeconds(t);
            }
            setAlpha(image, 0);

            yield return new WaitForSeconds(2f);
            image.gameObject.SetActive(false);
        }

        public IEnumerator FadeOut()
        {
            float a = 0, t, speed = 2f;
            image.gameObject.SetActive(true);

            setAlpha(image, a);
            while (a < 1)
            {
                t = Time.deltaTime;
                setAlpha(image, speed * t);
                yield return new WaitForSeconds(t);
            }
            setAlpha(image, 1);

            yield return new WaitForSeconds(2f);
            image.gameObject.SetActive(false);
        }

        void setAlpha(Image i, float a)
        {
            Color c = i.color;
            c.a = a;
            i.color = c;
        }
    }
}