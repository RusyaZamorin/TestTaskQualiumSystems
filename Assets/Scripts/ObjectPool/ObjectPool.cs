using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private List<GameObject> _objects = new List<GameObject>();

    public GameObject TakeObject(GameObject obj, Vector3 pos, Quaternion rot, Transform parrent)
    {
        if (_objects.Count == 0)
        {
            Create(obj, pos, rot, parrent);
            return _objects[0];
        }
        for (int i = 0; i < _objects.Count; i++)
        {
            if (!_objects[i].activeInHierarchy)
            {
                _objects[i].transform.position = pos;
                _objects[i].transform.rotation = rot;
                _objects[i].SetActive(true);
                return _objects[i];
            }
        }
        Create(obj, pos, rot, parrent);
        return _objects[_objects.Count - 1];
    }

    private void Create(GameObject obj, Vector3 pos, Quaternion rot, Transform parrent)
    {
        GameObject newObject = Instantiate(obj, pos, rot, parrent);
        _objects.Add(newObject);
    }
}