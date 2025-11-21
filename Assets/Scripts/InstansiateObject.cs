using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class InstansiateObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject objectPrefabType;

    public void Instansiate()
    {
        Instantiate(objectPrefabType);
    }
}
