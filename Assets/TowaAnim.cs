using DG.Tweening;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TowaAnim : MonoBehaviour
{
    [SerializeField] private Image towaSprite;
    [SerializeField] float defaultAnimationDuration = .3f;
    private bool zoomed = false;
    private bool fade = false;
    private bool flew = false;
    private bool flipped = false;
    public void ZoomAnimation()
    {
        if (!zoomed)
        {
            towaSprite.transform.DOScale(0f, defaultAnimationDuration);
        }
        else
        {
            towaSprite.transform.DOScale(1f, defaultAnimationDuration);
        }
        zoomed = !zoomed;
    }
    public void FadeAnimation()
    {
        if (!fade)
        {
            towaSprite.DOFade(0f, defaultAnimationDuration);
        }
        else
        {
            towaSprite.DOFade(1f, defaultAnimationDuration);
        }
        fade = !fade;
    }

    public void FlipAnimation()
    {
        if (!flipped)
        {
            towaSprite.transform.DORotate(new Vector3(0, 90, 0), defaultAnimationDuration).SetEase(Ease.InQuart);
        }
        else
        {
            towaSprite.transform.DORotate(new Vector3(0, 0, 0), defaultAnimationDuration).SetEase(Ease.OutQuart);


        }
        flipped = !flipped;
    }

    public void FlyAnimation()
    {
        if (!flew)
        {
            towaSprite.transform.DOMoveY(1500, defaultAnimationDuration).SetEase(Ease.InBack);
        }
        else
        {
            towaSprite.transform.DOMoveY(300, defaultAnimationDuration).SetEase(Ease.OutBack);

        }
        flew = !flew;
    }
    public void BounceAnimation()
    {
        towaSprite.transform.DOMoveY(660, defaultAnimationDuration).SetEase(Ease.InBounce).OnComplete(() => towaSprite.transform.DOMoveY(300, defaultAnimationDuration).SetEase(Ease.OutBounce));
    }
    public void ShakeAnimation()
    {
        towaSprite.transform.DOShakePosition(2f, 50);
    }
    public void FlashAnimation()
    {
        Sequence flashAnim = DOTween.Sequence();
        float flashDuration = .2f;
        flashAnim.Append(towaSprite.DOFade(0f, flashDuration).SetEase(Ease.OutQuint));
        flashAnim.Append(towaSprite.DOFade(1f, flashDuration).SetEase(Ease.OutQuint));
        flashAnim.Append(towaSprite.DOFade(0f, flashDuration).SetEase(Ease.OutQuint));
        flashAnim.Append(towaSprite.DOFade(1f, flashDuration).SetEase(Ease.OutQuint));
    }
    public void TadaAnimation()
    {
        Sequence tadaAnim = DOTween.Sequence();

        float tadaDuration = .1f;
        tadaAnim.Append(towaSprite.transform.DOScale(.3f, tadaDuration));
        tadaAnim.Append(towaSprite.transform.DOScale(1.5f, tadaDuration).SetEase(Ease.InQuart));
        tadaAnim.Append(towaSprite.transform.DORotate(new Vector3(0, 0, -8), tadaDuration));
        tadaAnim.Append(towaSprite.transform.DORotate(new Vector3(0, 0, 8), tadaDuration));
        tadaAnim.Append(towaSprite.transform.DORotate(new Vector3(0, 0, -8), tadaDuration));
        tadaAnim.Append(towaSprite.transform.DORotate(new Vector3(0, 0, 8), tadaDuration));
        tadaAnim.Append(towaSprite.transform.DORotate(new Vector3(0, 0, -8), tadaDuration));
        tadaAnim.Append(towaSprite.transform.DORotate(new Vector3(0, 0, 8), tadaDuration));
        tadaAnim.Append(towaSprite.transform.DORotate(new Vector3(0, 0, -8), tadaDuration));
        tadaAnim.Append(towaSprite.transform.DORotate(new Vector3(0, 0, 8), tadaDuration));
        tadaAnim.Append(towaSprite.transform.DORotate(new Vector3(0, 0, 0), tadaDuration));
        tadaAnim.Append(towaSprite.transform.DOScale(1f, tadaDuration).SetEase(Ease.OutQuart));

    }
}