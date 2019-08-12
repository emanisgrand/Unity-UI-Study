using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFillTest : MonoBehaviour
{
    private Image imageInstance;
    public int sign = 1;
    public bool buttonPressed = false;

    private float percentage;
    private float currentAmount;
    private float speed = 30;

    void Start()
    {
        imageInstance = GetComponent<Image>();

        if (imageInstance != null)
        {
            percentage = imageInstance.fillAmount * 100;
        }
    }

    void Update()
    {
        ButtonDown();
        ButtonUp();

        if (buttonPressed)
        {
            percentage += sign;
            print(percentage);

            if (percentage >= 100 || percentage <= 0)
            {
                sign *= -1;
                percentage = ((percentage <= 0) ? 0 : 100);
            }
        }
        imageInstance.fillAmount = percentage / 100;
    }

    void ButtonDown()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            buttonPressed = true;
        }
    }

    void ButtonUp()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            buttonPressed = false;
        }
    }
}
