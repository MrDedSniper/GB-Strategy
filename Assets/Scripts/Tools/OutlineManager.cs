using Abstractions;
using UnityEngine;
using UnityEngine.UI;

public class OutlineManager : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectableValue;
    private ISelectable _cashedSelectable;

    private void Awake()
    {
        _selectableValue.OnSelected += OnSelected;
        OnSelected(_selectableValue.CurrentValue);
    }

    private void OnSelected(ISelectable selectable)
    {
        if (selectable == _cashedSelectable) return;

        if (_cashedSelectable != null)
        {
            _cashedSelectable.PointerOfTransform.GetComponent<Outline>().enabled = false;
        }

        _cashedSelectable = selectable;
        
        if (selectable == null) return;
        
        Outline outline = selectable.PointerOfTransform.gameObject.GetComponent<Outline>();
            outline.enabled = true;
    }
}