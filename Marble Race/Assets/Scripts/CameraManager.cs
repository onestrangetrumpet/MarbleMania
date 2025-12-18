using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject[] cameras;
    public GameObject[] courseCameras;
    private int currentCameraIndex = 0;
    private int currentCourseCameraIndex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < courseCameras.Length; i++)
        {
            courseCameras[i].SetActive(i == currentCourseCameraIndex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            SwitchCameraCourse();
        }
    }

    void SwitchCamera()
    {
        
        cameras[currentCameraIndex].SetActive(false);
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
        cameras[currentCameraIndex].SetActive(true);
    }

    public void SwitchCamera(int index)
    {
        if (index >= 0 && index < cameras.Length)
        {
            cameras[currentCameraIndex].SetActive(false);
            currentCameraIndex = index;
            cameras[currentCameraIndex].SetActive(true);
        }
        else
        {
            Debug.LogWarning("Invalid camera index provided.");
        }
    }


    void SwitchCameraCourse()
    {
        courseCameras[currentCourseCameraIndex].SetActive(false);
        currentCourseCameraIndex = (currentCourseCameraIndex + 1) % courseCameras.Length;
        courseCameras[currentCourseCameraIndex].SetActive(true);
    }

    public void SwitchCameraCourse(int index)
    {
        if (index >= 0 && index < courseCameras.Length)
        {
            courseCameras[currentCourseCameraIndex].SetActive(false);
            currentCourseCameraIndex = index;
            courseCameras[currentCourseCameraIndex].SetActive(true);
        }
        else
        {
            Debug.LogWarning("Invalid camera index provided.");
        }
    }
}
