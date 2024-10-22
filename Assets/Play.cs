using UnityEngine;
using UnityEngine.Video;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponent<VideoPlayer>().isPlaying)
            {
                GetComponent<VideoPlayer>().Pause();
            }
            else
                GetComponent<VideoPlayer>().Play();
        }
    }

    public void VideoPlay()
    {
        GetComponent<VideoPlayer>().Play();
    }
    public void VideoPause()
    {
        GetComponent<VideoPlayer>().Pause();
    }
}
