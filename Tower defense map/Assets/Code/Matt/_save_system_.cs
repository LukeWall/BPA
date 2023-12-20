using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _new_save_system : MonoBehaviour
{


}

//Make an object saveable
public interface _saveable_
{
    object _capture_state_();
    void _restore_state_(object state);


}
