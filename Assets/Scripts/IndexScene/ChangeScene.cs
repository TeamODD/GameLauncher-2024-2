using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace IndexScene
{
    public class ChangeScene : MonoBehaviour
    {
        [SerializeField] Image oddLogo;

        string nextScene = "MainScene";
        Coroutine cor = null;

        void Start()
        {
            cor = StartCoroutine(introAction());
        }

        void Update()
        {
            if (Input.anyKeyDown || Input.GetMouseButtonDown(0))
            {
                StopCoroutine(cor);
                setAlpha(oddLogo, 0);
                SceneManager.LoadScene(nextScene);
            }
        }

        IEnumerator introAction()
        {
            float alpha = 0, speed = 2f, time;

            yield return new WaitForSeconds(0.3f);

            oddLogo.gameObject.SetActive(true);
            setAlpha(oddLogo, alpha);
            while (alpha < 1)
            {
                time = Time.deltaTime;
                alpha += speed * time;
                setAlpha(oddLogo, alpha);
                yield return new WaitForSeconds(time);
            }
            alpha = 1;
            setAlpha(oddLogo, alpha);
            yield return new WaitForSeconds(2f);

            while (0 < alpha)
            {
                time = Time.deltaTime;
                alpha -= speed * time;
                setAlpha(oddLogo, alpha);
                yield return new WaitForSeconds(time);
            }
            alpha = 0;
            setAlpha(oddLogo, alpha);

            oddLogo.gameObject.SetActive(false);
            SceneManager.LoadScene(nextScene);
        }

        IEnumerator fadeIn()
        {
            float alpha = 1, speed = 2f, time;

            oddLogo.gameObject.SetActive(true);
            setAlpha(oddLogo, alpha);
            while (0 < alpha)
            {
                time = Time.deltaTime;
                alpha -= speed * time;
                setAlpha(oddLogo, alpha);
                yield return new WaitForSeconds(time);
            }
            alpha = 0;
            setAlpha(oddLogo, alpha);

            oddLogo.gameObject.SetActive(false);
            SceneManager.LoadScene(nextScene);
        }

        IEnumerator fadeOut()
        {
            float alpha = 0, speed = 2f, time;

            oddLogo.gameObject.SetActive(true);
            setAlpha(oddLogo, alpha);
            while (alpha < 1)
            {
                time = Time.deltaTime;
                alpha += speed * time;
                setAlpha(oddLogo, alpha);
                yield return new WaitForSeconds(time);
            }
            alpha = 1;
            setAlpha(oddLogo, alpha);

            yield return new WaitForSeconds(2f);
            oddLogo.gameObject.SetActive(false);
            SceneManager.LoadScene(nextScene);
        }

        void setAlpha(Image image, float alpha)
        {
            Color c;
            c = image.color;
            c.a = alpha;
            image.color = c;
        }
    }
}