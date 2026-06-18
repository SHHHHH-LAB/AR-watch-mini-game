using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorSelect : MonoBehaviour
{
    //三个表带材质
    public Material band1;
    public Material band2;
    public Material band3;

    //手表1颜色切换
    public void w1ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        Color myColor;
        if (buttonName == "Black Button")
        {
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band1.color = myColor;
        }
        else if (buttonName == "Blue Button")
        {
            ColorUtility.TryParseHtmlString("#103B90", out myColor);
            band1.color = myColor;
        }
    }

    //手表2颜色切换
    public void W2ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        Color myColor;
        if (buttonName == "Black Button")
        {
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;
        }
        else if (buttonName == "Red Button")
        {
            ColorUtility.TryParseHtmlString("#740202", out myColor);
            band2.color = myColor;
        }
    }

    //手表3颜色切换
    public void W3ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        Color myColor;
        if (buttonName == "Black Button")
        {
            ColorUtility.TryParseHtmlString("#464646", out myColor);
            band3.color = myColor;
        }
        else if (buttonName == "Silver Button")
        {
            ColorUtility.TryParseHtmlString("#AAAAAA", out myColor);
            band3.color = myColor;
        }
    }
}