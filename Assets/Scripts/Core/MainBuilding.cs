using Abstractions;
using UnityEngine;
using UnityEngine.UI;

public class MainBuilding : MonoBehaviour, IUnitProducer, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    
    public bool IsSelected { get; set; }
    public Transform PointerOfTransform { get; }

    [SerializeField] private GameObject _unitPrefab;
    [SerializeField] private Transform _unitsParent;
    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;
    private float _health = 1000;

    public void ProduceUnit()
    {
        Instantiate(_unitPrefab, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10,
            10)), Quaternion.identity, _unitsParent);
    }
}
