using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AutoAnimationUI : MonoBehaviour
{
    [SerializeField] private float Duration;
    [SerializeField] private Sprite[] Sprites;
    [SerializeField] private Image MainImage;

    private void OnEnable()
    {
        StartCoroutine(Excute());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
    IEnumerator Excute()
    {
        int index = 0;
        while (true)
        {
            yield return new WaitForSeconds(Duration);
            MainImage.sprite = Sprites[index % Sprites.Length];
            MainImage.SetNativeSize();
            index++;
        }
    }
}
