using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Weapon> _weapons;
    private int _currentWeaponIndex;
    private float _scroll;

    private void Start()
    {
        _weapons[_currentWeaponIndex].gameObject.SetActive(true);
    }

    public void OnWeaponChange(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Vector2 vector = Mouse.current.scroll.ReadValue();
            _scroll = vector.y;
            Weapon currentWeapon = _weapons[_currentWeaponIndex];
            currentWeapon.gameObject.SetActive(false);
            int newWeaponIndex = _scroll > 0 ? GetNextWeaponIndex() : GetPreviousWeaponIndex();
            currentWeapon = _weapons[newWeaponIndex];
            currentWeapon.gameObject.SetActive(true);
            _currentWeaponIndex = newWeaponIndex;
        }
    }

    private int GetNextWeaponIndex()
    {
        if (_currentWeaponIndex == _weapons.Count - 1)
        {
            return 0;
        }
        return _currentWeaponIndex + 1;
    }

    private int GetPreviousWeaponIndex()
    {
        if (_currentWeaponIndex == 0)
        {
            return _weapons.Count - 1;
        }
        return _currentWeaponIndex - 1;
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _weapons[_currentWeaponIndex].OnFire();
        }
    }
}
