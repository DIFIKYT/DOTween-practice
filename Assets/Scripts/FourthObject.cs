using DG.Tweening;
using UnityEngine;

public class FourthObject : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private Vector3 _targetRotate;
    [SerializeField] private Vector3 _targetSize;

    [SerializeField] private float _moveChangeDuration;
    [SerializeField] private float _rotateChangeDuration;
    [SerializeField] private float _sizeChangeDuration;

    [SerializeField] private int _moveChangeRepeats;
    [SerializeField] private int _rotateChangeRepeats;
    [SerializeField] private int _sizeChangeRepeats;

    [SerializeField] private LoopType _moveLoopType;
    [SerializeField] private LoopType _rotateLoopType;
    [SerializeField] private LoopType _sizeLoopType;

    private void Start()
    {
        transform.DOMove(_targetPosition, _moveChangeDuration).SetLoops(_moveChangeRepeats, _moveLoopType).SetEase(Ease.Linear);
        transform.DORotate(_targetRotate, _rotateChangeDuration).SetLoops(_rotateChangeRepeats, _rotateLoopType).SetEase(Ease.Linear);
        transform.DOScale(_targetSize, _sizeChangeDuration).SetLoops(_sizeChangeRepeats, _sizeLoopType).SetEase(Ease.Linear);
    }
}