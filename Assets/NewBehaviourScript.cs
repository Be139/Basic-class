using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
   public string playerName = "Bot";
   public int sanity = 45;
   public float speed = 3.5f;
   public bool isAlive = true;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("我的名字是：" + playerName + "，理智值：" + sanity + "，速度：" + speed + "，是否活着：" + isAlive);

        if (sanity >= 60)
        {
            Debug.Log("状态：精神很好");
        }
        else if (sanity >= 30 && sanity <= 59)
        {
            Debug.Log("状态：有点疲惫");
        }
        else
        {
            Debug.Log("状态：精神崩溃，快不行了");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
