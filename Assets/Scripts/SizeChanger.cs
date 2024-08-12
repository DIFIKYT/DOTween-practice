using DG.Tweening;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _targetSize;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_targetSize, _duration).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
    }
}