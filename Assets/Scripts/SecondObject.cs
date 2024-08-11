using DG.Tweening;
using UnityEngine;

public class SecondObject : MonoBehaviour
{
    [SerializeField] private Vector3 _targetRotate;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DORotate(_targetRotate, _duration).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
    }
}