using UnityEngine;
using DG.Tweening;

public class FloatingCoin : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    void Start()
    {
        transform.DOMoveY(transform.position.y +0.5f, 1f)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.InOutSine);
    }

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
