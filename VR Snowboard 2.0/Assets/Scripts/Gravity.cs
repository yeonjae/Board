using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour
{

    public GUIText _test; // 디버그를 위한 GUI TEXT
    public GameObject _target; // 가속도 센서를 적용할 객체, 여기서는 판

    // Update is called once per frame
    void Update()
    {

        // 가속도 센서 디버그, 게임에 영향없음
        _test.text = Input.acceleration.ToString();

        // 객체의 각도 값을, 스마트폰의 각도와 동일시함
        _target.transform.localEulerAngles =
            new Vector3(Input.acceleration.y * 90.0f, Input.acceleration.z * 90.0f, Input.acceleration.x * -90.0f);
    }
}
