using System.Collections;
using UnityEngine;

public class LongClickButton : MonoBehaviour
{
    private bool isPointerDown = false;
    private Coroutine longClickCoroutine;
    public const float longClickDuration = 1f;
    public const float OnRepeatedClick = 0.05f;
    public void OnPointerDown()
    {
        isPointerDown = true;
        longClickCoroutine = StartCoroutine(LongClickCoroutine());
    }

    public void OnPointerUp()
    {
        isPointerDown = false;
        if (longClickCoroutine != null)
        {
            StopCoroutine(longClickCoroutine);
            longClickCoroutine = null;
        }
    }

    private IEnumerator LongClickCoroutine()
    {
        yield return new WaitForSeconds(longClickDuration);
        if (isPointerDown)
        {
            while (isPointerDown)
            {
                yield return new WaitForSeconds(OnRepeatedClick);
                //OnClick();
                //Call the function you want to fire when clicked like above
            }
        }
    }
    
    /// <summary>
    /// example function
    /// After checking the price and maximum level, raise it, save it, and update the text.
    /// </summary>
    public void OnClick()
    {
        /*
        if (Price > Wallet.instance.Gold)
            return;
        if (level >= MaxLevel)
            return;

        Wallet.instance.Gold -= (long)Price;
        level++;
        Save();
        UpdateText();
        */
    }
    
}
