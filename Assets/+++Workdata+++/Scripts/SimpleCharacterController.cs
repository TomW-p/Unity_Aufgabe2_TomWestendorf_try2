using UnityEngine;
using UnityEngine.InputSystem;


public class MostSimpleCharacterController : MonoBehaviour
{

    [SerializeField] private float speed = 2f;
    private Vector3 direction = new Vector3(x: 0, y: 0);

    [SerializeField] private CoinManager coinManager;
    [SerializeField] private UIManager uiManager;
    
    [SerializeField] private bool canMove = true;

    void Update()
    {
        if (canMove)
        {
            transform.position += direction.normalized * Time.deltaTime * speed;

            direction = Vector3.zero;

            if (Keyboard.current.wKey.isPressed)
            {
                direction.y = 1;
                //Debug.Log(message: "SpaceKey pressed" );
            }

            if (Keyboard.current.aKey.isPressed)
            {
                direction.x = -1;
                //Debug.Log(message: "SpaceKey pressed" );
            }

            if (Keyboard.current.sKey.isPressed)
            {
                direction.y = -1;
                //Debug.Log(message: "SpaceKey pressed" );
            }

            if (Keyboard.current.dKey.isPressed)
            {
                direction.x = 1;
                //direction = Vector3.right;
                //Debug.Log(message: "SpaceKey pressed" );
            }
            
            if (Keyboard.current.qKey.isPressed)
            {
                transform.Rotate(eulers:new Vector3(0f, 0f, 40f)*Time.deltaTime);
            }
            
            if (Keyboard.current.eKey.isPressed)
            {
                transform.Rotate(eulers:new Vector3(0f, 0f, -40f)*Time.deltaTime);
            }
        }
    }
    
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(message: "Wir sind mit etwas kollidiert");
        
        if (other.CompareTag("Money"))
        {
            //Debug.Log(message: "Es war ein Coin");
            Destroy(other.gameObject);
            
            // .AddCoin()
            
            coinManager.AddCoin();
        } 
        else if (other.CompareTag("Water"))
        {
            //Debug.Log(message: "Es war ein Obstacle");
            //uiManager.ShowPanelLost();
            canMove = false;
        }
        
    }
}