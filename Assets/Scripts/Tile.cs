using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tile : MonoBehaviour
{
    [System.Serializable]
    public class State
    {
        public Color _fillColor;
        public Color _outlineColor;
    }

    public State state { get; private set; }
    public char letter { get; private set; }

    private TextMeshProUGUI _text;
    private Image _fill;
    private Outline _outline;

    private void Awake()
    {
        _text = GetComponentInChildren<TextMeshProUGUI>();
        _fill = GetComponent<Image>();
        _outline = GetComponent<Outline>();
    }

    public void SetLetter(char letter)
    {
        this.letter = letter;
        _text.text = letter.ToString();
    }

    public void SetState(State state)
    {
        this.state = state;
        _fill.color = state._fillColor;
        _outline.effectColor = state._outlineColor;
    }
}
