using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    public GameObject hrac;

    public Vector3 endPosition;
    public Vector3 startPosition;

    public float timeStartedLerping;
    public float lerpTime;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {            
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("kolize");
        timeStartedLerping = Time.fixedTime;

        transform.position = Lerp(startPosition, endPosition, timeStartedLerping, lerpTime);

    }

    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;

        float percentageComplete = timeSinceStarted / lerpTime;

        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }
}
