using UnityEngine;

namespace Abstractions
{
    public interface ISelectable
    {
        float Health { get; }
        float MaxHealth { get; }
        Sprite Icon { get; }
        public bool IsSelected { get; set; }
        
        Transform PointerOfTransform { get; }
        
    }
}
