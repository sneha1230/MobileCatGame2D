using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    public float obstacleSpeed;
    // Start is called before the first frame update
   private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, obstacleSpeed));
    }
}
