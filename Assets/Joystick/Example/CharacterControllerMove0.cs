using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using zFrame.UI;

public class CharacterControllerMove0 : MonoBehaviour
{
    [SerializeField] Joystick joystick;
    public float speed = 5;
    CharacterController controller;// 角色控制器
    void Start()
    {
        controller = GetComponent<CharacterController>();

        joystick.OnValueChanged.AddListener(v =>
        {
            if (v.magnitude != 0)
            {
                Vector3 direction = new Vector3(v.x, 0, v.y);
                controller.Move(direction * speed * Time.deltaTime);// 角色控制器移动
                transform.rotation = Quaternion.LookRotation(new Vector3(v.x, 0, v.y));
            }
        });
    }
}
