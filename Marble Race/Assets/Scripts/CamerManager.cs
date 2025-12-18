// using UnityEngine;

// public class CamerManager : MonoBehaviour
// {
//     public GameObject[] cameras;
//     private int currentCameraIndex = 0;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         for (int i = 0; i < cameras.Length; i++)
//         {
//             cameras[i].SetActive(i == currentCameraIndex);
//         }
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.V))
//         {
//             SwitchCamera();
//         }
//     }

//     void SwitchCamera()
//     {
//         cameras[currentCameraIndex].SetActive(false);
//         currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
//         cameras[currentCameraIndex].SetActive(true);
//     }

//     public void SwitchCamera(int index)
//     {
//         if (index >= 0 && index < cameras.Length)
//         {
//             cameras[currentCameraIndex].SetActive(false);
//             currentCameraIndex = index;
//             cameras[currentCameraIndex].SetActive(true);
//         }
//         else
//         {
//             Debug.LogWarning("Invalid camera index provided.");
//         }
//     }
// }
