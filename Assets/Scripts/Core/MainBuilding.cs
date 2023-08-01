using Abstractions;
using UnityEngine;
using UnityEngine.UI;

public class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    public bool IsSelected { get; set; }
    public Transform PointerOfTransform { get; }
    [SerializeField] private Transform _unitsParent;
    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;
    private float _health = 1000;
    private ISelectable _selectableImplementation;

    public void ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), 0,
            Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
    }

    public override void ExecuteSpecificCommand<T>(T command)
    {
        throw new System.NotImplementedException();
    }
}
