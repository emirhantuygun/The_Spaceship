using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed = 30f;
    public float rotateBackDuration = 1f;
    private Quaternion initialRotation;
    private Quaternion lastYRotation;
    private bool isTouching = false;

    void OnEnable()
    {
        initialRotation = Quaternion.identity;
        transform.rotation = initialRotation;
        lastYRotation = initialRotation;
        StartCoroutine(RotateObjectCoroutine());
    }

    IEnumerator RotateObjectCoroutine()
    {
        isTouching = false;
        while (true)
        {
            if (!isTouching)
            {
                transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f, Space.World);
            }
            yield return null;
        }
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (!isTouching)
                    {
                        isTouching = true;
                        lastYRotation = transform.rotation;
                    }
                    break;

                case TouchPhase.Moved:
                    if (isTouching)
                    {
                        float rotateX = touch.deltaPosition.y * rotateSpeed * Time.deltaTime;
                        float rotateY = -touch.deltaPosition.x * rotateSpeed * Time.deltaTime;
                        transform.Rotate(rotateX, rotateY, 0f, Space.World);
                    }
                    break;

                case TouchPhase.Ended:
                    if (isTouching)
                    {
                        isTouching = false;
                        StartCoroutine(RotateBackToLastYRotation());
                    }
                    break;
            }
        }
    }

    IEnumerator RotateBackToLastYRotation()
    {
        isTouching = true;

        float t = 0f;
        Quaternion currentRotation = transform.rotation;
        Quaternion targetRotation = lastYRotation;

        while (t < 1f)
        {
            t += Time.deltaTime / rotateBackDuration;
            transform.rotation = Quaternion.Lerp(currentRotation, targetRotation, t);
            yield return null;
        }

        isTouching = false;
    }
}