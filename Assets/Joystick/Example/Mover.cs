using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using zFrame.UI;

// 人物移动脚本
public class Mover : MonoBehaviour
{
    [SerializeField] Joystick joystick;
    public float speed = 5;
    void Start()
    {
        // 给摇杆事件加个监听
        joystick.OnValueChanged.AddListener(v =>
        {
            if (v.magnitude != 0)
            {
                transform.Translate(v.x * speed * Time.deltaTime, 0, v.y * speed * Time.deltaTime, Space.World);// Translate移动
                transform.rotation = Quaternion.LookRotation(new Vector3(v.x, 0, v.y));
            }
        });
    }
}
