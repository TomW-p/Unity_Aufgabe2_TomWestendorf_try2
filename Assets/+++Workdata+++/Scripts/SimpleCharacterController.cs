using UnityEngine;
using UnityEngine.InputSystem;


public class MostSimpleCharacterController : MonoBehaviour
{

    [SerializeField] private float speed = 2f;
    private Vector3 direction = new Vector3(x: 0, y: 0);

    [SerializeField] private CoinManager coinManager;
    [SerializeField] private SceneController sceneController;
    
    void Update()
    {
            transform.position += direction.normalized * Time.deltaTime * speed;

            direction = Vector3.zero;

            if (Keyboard.current.wKey.isPressed)
            {
                direction.y = 1;
            }

            if (Keyboard.current.aKey.isPressed)
            {
                direction.x = -1;
            }

            if (Keyboard.current.sKey.isPressed)
            {
                direction.y = -1;
            }

            if (Keyboard.current.dKey.isPressed)
            {
                direction.x = 1;
            }
            
            if (Keyboard.current.qKey.isPressed)
            {
                transform.Rotate(eulers:new Vector3(0f, 0f, 10f)*Time.deltaTime*speed);
            }
            
            if (Keyboard.current.eKey.isPressed)
            {
                transform.Rotate(eulers:new Vector3(0f, 0f, -10f)*Time.deltaTime*speed);
            }
    }
    
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Money"))
        {
            Destroy(other.gameObject);
            
            coinManager.AddCoin();
        } 
        else if (other.CompareTag("Water"))
        {
            sceneController.PlayerDeath();
        }
    }
}