using UnityEngine;
using UnityEngine.Video; // <--- BẮT BUỘC PHẢI CÓ DÒNG NÀY MỚI DÙNG ĐƯỢC VIDEO

public class Lab5Controller : MonoBehaviour
{
    public VideoPlayer myVideoPlayer;

    void Update()
    {
        // Nhấn phím V để phát video
        if (Input.GetKeyDown(KeyCode.V))
        {
            myVideoPlayer.Play();
            Debug.Log("Dang phat Video...");
        }
    }
}