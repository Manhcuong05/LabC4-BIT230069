using UnityEngine;

public class Lab3_GlobalControl : MonoBehaviour
{
    // Biến lưu trạng thái xem có đang Mute không
    private bool isMuted = false;

    void Update()
    {
        // --- CHỨC NĂNG 1: MUTE (Phím M) ---
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isMuted == false)
            {
                // Đang mở -> Chuyển thành Tắt
                AudioListener.volume = 0; // Vặn volume tổng về 0
                isMuted = true;
                Debug.Log("Đã tắt tiếng (Mute)");
            }
            else
            {
                // Đang tắt -> Chuyển thành Mở
                AudioListener.volume = 1; // Vặn volume tổng lên 1 (Max)
                isMuted = false;
                Debug.Log("Đã mở tiếng (Unmute)");
            }
        }

        // --- CHỨC NĂNG 2: PAUSE (Phím P) ---
        if (Input.GetKeyDown(KeyCode.P))
        {
            // AudioListener.pause là biến boolean (true/false)
            // Lệnh dưới đây có nghĩa là: Đảo ngược trạng thái hiện tại
            // Nếu đang chạy thì Pause, nếu đang Pause thì chạy tiếp
            AudioListener.pause = !AudioListener.pause;
            
            if(AudioListener.pause) Debug.Log("Đã tạm dừng âm thanh (Pause)");
            else Debug.Log("Đã tiếp tục phát (Resume)");
        }
    }
}