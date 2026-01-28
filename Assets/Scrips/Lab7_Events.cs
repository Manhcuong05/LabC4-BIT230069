using UnityEngine;
using UnityEngine.Video; // Thư viện Video
using UnityEngine.UI;    // Thư viện UI

public class Lab7_Events : MonoBehaviour
{
    public VideoPlayer myVideo; // Kéo Video Player vào đây
    public GameObject messageUI; // Kéo cái chữ "Hết Video" vào đây

    void Start()
    {
        // Đăng ký sự kiện: Khi video chạy đến điểm cuối (hoặc hết vòng lặp)
        // Thì gọi hàm OnVideoFinished
        myVideo.loopPointReached += OnVideoFinished;
    }

    // Hàm này sẽ tự động chạy khi video hết
    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("Video đã chạy xong!");
        
        // Hiện dòng chữ lên
        messageUI.SetActive(true);
        
        // (Mở rộng: Nếu muốn chuyển Scene thì dùng SceneManager.LoadScene("Level1");)
    }
}