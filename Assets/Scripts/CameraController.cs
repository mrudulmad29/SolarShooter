using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform playerPosition;

    public float cameraSafeOffsetSizeX = 5.0f;
    public float cameraSafeOffsetSizeY = 5.0f;

    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPosition != null)
        {
            if (playerPosition.position.y < transform.position.y - (0.5f * cameraSafeOffsetSizeY))
            {
                // Start following the player
                transform.position = new Vector3(
                    playerPosition.position.y + (0.5f * cameraSafeOffsetSizeY), // X
                    transform.position.x,                                       // Y
                    transform.position.z);                                      // Z
            }
            else if (playerPosition.position.y > transform.position.y + (0.5f * cameraSafeOffsetSizeY))
            {
                transform.position = new Vector3(
                    playerPosition.position.y - (0.5f * cameraSafeOffsetSizeY), // X
                    transform.position.x,                                       // Y
                    transform.position.z);                                      // Z
            }
        }
    }

    void OnDrawGizmos()
    {
        Vector3 thresholdL = new Vector3(
            transform.position.y - (0.5f * cameraSafeOffsetSizeY),
            transform.position.x,
            transform.position.z);

        Vector3 thresholdR = new Vector3(
            transform.position.y + (0.5f * cameraSafeOffsetSizeY),
            transform.position.x,
            transform.position.z);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(
            new Vector3(thresholdL.x + 10, thresholdL.y, thresholdL.z),
            new Vector3(thresholdL.x - 10, thresholdL.y, thresholdL.z));
        Gizmos.DrawLine(
            new Vector3(thresholdR.x + 10, thresholdR.y, thresholdR.z),
            new Vector3(thresholdR.x - 10, thresholdR.y, thresholdR.z));
    }
}