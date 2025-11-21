using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class InstansiateObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject objectPrefabType;

    [SerializeField] private Vector3 spawnPosition;

    public void Instansiate()
    {
        Instantiate(objectPrefabType, spawnPosition, Quaternion.identity);
    }
}
