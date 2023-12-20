using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System;

// This is meant to send the captured state to a text file and give it a data path
[System.Serializable]
public class _player_profile_ : MonoBehaviour
{
    //Setting up the persistent path and giving it a name
    private string _save_path_ => $"{Application.persistentDataPath}?save.txt";
    // The save 
    [ContextMenu("Save")]
    private void _save_()
    {
        var state = _load_file();
        _capture_state_(state);
        _save_file_(state);
    }
    // The load
    [ContextMenu("Load")]
    private void _load_()
    {
        var state = _load_file();
        _restore_state_(state);

    }
    // This makes sure that there is a save file when the game attemps to load a save file
    private Dictionary<string, object> _load_file()
    {
        if (!File.Exists(_save_path_))
        {
            return new Dictionary<string, object>();
        }

        using (FileStream stream = File.Open(_save_path_, FileMode.Open))
        {
            var formatter = new BinaryFormatter();
            return (Dictionary<string, object>)formatter.Deserialize(stream);
        }
    }
    // Makes the save file
    private void _save_file_(object state)
    {
        using (var stream = File.Open(_save_path_, FileMode.Create))
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, state);
        }
    }
    //Captures the stat of the object
    private void _capture_state_(Dictionary<string, object> state)
    {
        foreach (var saveable in FindObjectsOfType<_position_save_>())
        {
            state[saveable._id] = saveable._capture_state_();
        }
    }
    //Restores the state of the object
    private void _restore_state_(Dictionary<string, object> state)
    {
        foreach (var saveable in FindObjectsOfType<_position_save_>())
        {
            if (state.TryGetValue(saveable._id, out object value))
            {
                saveable._restore_state_(value);
            }
        }
    }

}