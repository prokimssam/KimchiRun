using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerController2 : MonoBehaviour
{
    void Update()
    {
        // 현재 연결된 키보드 장치가 있는지 먼저 체크 (안전장치)
        var key = Keyboard.current;
        if (key == null) return;

        // 2. 해당 키를 "누르는 순간" 한 번만 실행 (GetKeyDown 대응)
        if (key.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("스페이스바를 눌렀습니다!");
        }

        // 3. keyboard 해당 키를 "누르고 있는 동안" 계속 실행 (GetKey 대응)
        if (key.wKey.isPressed)
        {
            Debug.Log("W 키를 누르는 중...");
        }
    }
}
