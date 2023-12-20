using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
//Sets up the values that need to be saved
public class Manager : MonoBehaviour, _saveable_
{
    /*
    [SerializeField] private float _x_position_ = 0; *Example
    [SerializeField] private float _y_position_ = 0; *Example
    [SerializeField] private float _z_position_ = 0; *Example
    */
    // captures the state of the project
    public object _capture_state_()
    {
        return new _save_data_
        {
            /*
            _x_position_ = _x_position_, *Example
            _y_position_ = _y_position_, *Example
            _z_position_ = _z_position_ *Example
            */
        };
    }
    // Restores the state of the project
    public void _restore_state_(object state)
    {
        var _savedata_ = (_save_data_)state;
        /*
        _x_position_ = _savedata_._x_position_; *Example
        _y_position_ = _savedata_._y_position_; *Example
        _z_position_ = _savedata_._z_position_; *Example
        */
    }

    // Sets up the the save data to be used throughout the program
    [Serializable]
    private struct _save_data_
    {
        /*
        public float _x_position_; *Example
        public float _y_position_; *Example
        public float _z_position_; *Example
        */
    }
}
