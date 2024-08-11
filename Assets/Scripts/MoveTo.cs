using DG.Tweening;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    private void Update()
    {
        transform.DOMove(new Vector3(5, 5, 5), 5, true);
    }
}