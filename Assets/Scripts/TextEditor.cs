using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextEditor : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _textChangeDuration;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("������ ������", _textChangeDuration));
        sequence.Append(_text.DOText("���������� ������", _textChangeDuration).SetRelative());
        sequence.Append(_text.DOColor(Color.green, 0));
        sequence.Append(_text.DOText("����� ������", _textChangeDuration, true, ScrambleMode.Numerals));
    }
}