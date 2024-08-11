using DG.Tweening;
using UnityEngine;

public class FirstObject : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
    }
}