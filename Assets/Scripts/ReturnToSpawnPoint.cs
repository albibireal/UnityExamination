using UnityEngine;

public class ReturnToSpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    
        private Vector3 startPosition;
    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            startPosition = playerTransform.position;
        }
    
        // Update is called once per frame
        void Update()
        {
            
        }
    
        public void ReturnPlayer()
        {
            playerTransform.position = startPosition;
        }
}
