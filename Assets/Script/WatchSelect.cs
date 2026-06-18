using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{
    //手表模型对象
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    //三个详情弹窗
    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    //替换成Animator
    private Animator w1Anim;
    private Animator w2Anim;
    private Animator w3Anim;

    void Start()
    {
        //获取Animator组件
        w1Anim = w1Window.GetComponent<Animator>();
        w2Anim = w2Window.GetComponent<Animator>();
        w3Anim = w3Window.GetComponent<Animator>();

        //弹窗默认显示在场景外（靠动画控制进出）


        // 加这一句！强制开局关闭
        w1Anim.SetBool("IsOpen", false);
        w2Anim.SetBool("IsOpen", false);
        w3Anim.SetBool("IsOpen", false);
        
        w1Window.SetActive(true);
        w2Window.SetActive(true);
        w3Window.SetActive(true);
    }

    //点击手表1按钮：播放入场Open
    public void WatchOneButtonClicked()
    {
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);
        //播放入场动画（状态名Open）
        w1Anim.Play("Open", 0, 0);
    }

    //点击手表2按钮
    public void WatchTwoButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);
        w2Anim.Play("Open", 0, 0);
    }

    //点击手表3按钮
    public void WatchThreeButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);
        w3Anim.Play("Open", 0, 0);
    }

    //关闭按钮：播放退场Close
    public void CloseButtonClicked()
    {
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        if (btnName == "w1close")
        {
            w1Anim.Play("Close", 0, 0);
        }
        else if (btnName == "w2close")
        {
            w2Anim.Play("Close", 0, 0);
        }
        else if (btnName == "w3close")
        {
            w3Anim.Play("Close", 0, 0);
        }
    }
}