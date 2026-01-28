using UnityEngine;

public class Lab1Controller : MonoBehaviour
{
    // Tạo biến để chứa cái Loa
    public AudioSource myAudio;

    void Update()
    {
        // Nếu nhấn phím Space (Phím Cách)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAudio.Play(); // Ra lệnh phát
            Debug.Log("Dang phat nhac (Play)");
        }

        // Nếu nhấn phím S
        if (Input.GetKeyDown(KeyCode.S))
        {
            myAudio.Stop(); // Ra lệnh dừng
            Debug.Log("Da dung nhac (Stop)");
        }
    }
}