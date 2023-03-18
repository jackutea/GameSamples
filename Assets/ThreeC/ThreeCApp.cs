using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeCApp : MonoBehaviour {

    GameObject role;
    Camera mainCam;

    void Start() {
        role = GameObject.Find("Role");
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update() {

        float speed = 5.5f;
        float dt = Time.deltaTime;

        // 1. ProcessInput 获取输入
        Vector2 moveDir = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) {
            moveDir.y = 1;
        } else if (Input.GetKey(KeyCode.S)) {
            moveDir.y = -1;
        }
        if (Input.GetKey(KeyCode.A)) {
            moveDir.x = -1;
        } else if (Input.GetKey(KeyCode.D)) {
            moveDir.x = 1;
        }

        moveDir.Normalize();
        moveDir *= speed;

        // 相机方向
        Vector3 cameraForward = mainCam.transform.forward;
        Vector3 cameraRight = mainCam.transform.right;

        Vector3 rolePos = role.transform.position;
        Vector3 destOffset = cameraForward * moveDir.y + cameraRight * moveDir.x;
        destOffset.y = 0;
        destOffset.Normalize();
        role.transform.position = rolePos + destOffset * dt;

        // 2. DoLogic 处理逻辑
        // 3. Render 渲染(Unity 解决了)
    }

    void LateUpdate() {
        // 相机跟随
        Vector3 rolePos = role.transform.position;
        Vector3 cameraPos = mainCam.transform.position;
        cameraPos.x = rolePos.x;
        cameraPos.z = rolePos.z + -10;
        mainCam.transform.position = cameraPos;
    }
}
