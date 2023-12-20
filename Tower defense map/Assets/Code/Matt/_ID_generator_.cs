using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Generates the ID that the save file has
public class _position_save_ : MonoBehaviour
{
    [SerializeField] private string id_ = string.Empty;

    public string _id => id_;
    // Allow the project to have an object to generate an ID
    [ContextMenu("Generate Id")]

    private void GenerateId() => id_ = Guid.NewGuid().ToString();
    // Captures state of an object that is "_saveable
    public object _capture_state_()
    {
        var state = new Dictionary<string, object>();

        foreach (var saveable in GetComponents<_saveable_>())
        {
            state[saveable.GetType().ToString()] = saveable._capture_state_();
        }
        return state;

    }

    public void _restore_state_(object state)
    {
        var _state_dictonary_ = (Dictionary<string, object>)state;

        foreach (var saveable in GetComponents<_saveable_>())
        {
            string _type_name_ = saveable.GetType().ToString();
            if (_state_dictonary_.TryGetValue(_type_name_, out object value))
            {
                saveable._restore_state_(value);
            }
        }
    }
}
