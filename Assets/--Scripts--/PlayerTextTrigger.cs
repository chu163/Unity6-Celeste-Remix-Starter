using UnityEngine;

public class PlayerTextTrigger : MonoBehaviour {
    public InfoProperty info = new InfoProperty( "Using the PlayerTextTrigger Component",
         "1. The <b>Circle Collider 2D</b> on this GameObject controls when this will appear.\n" +
         "2. You can swap out the <b>Sprite</b> on the <b>Sprite Renderer</b> to have different images (or no image).\n" +
         "3. The <b>Text (TMP)</b> grandchild of this GameObject controls the text that is displayed.\n\n");

    private Canvas _canvas;
    void Awake() {
        _canvas = GetComponentInChildren<Canvas>();
        _canvas.enabled = false;
    }
    
    
    // OnTriggerEnter2D is called by the Physics engine when the Player enters this Trigger Collider.
    // It is only called by the Player layer due to settings on the Circle Collider 2D
    void OnTriggerEnter2D( Collider2D coll ) {
        if ( coll.CompareTag( "Player" ) ) {
            _canvas.enabled = true;
        }
    }
    
    // OnTriggerExit2D is called by the Physics engine when the Player leaves this Trigger Collider.
    // It is only called by the Player layer due to settings on the Circle Collider 2D
    void OnTriggerExit2D( Collider2D coll ) {
        if ( coll.CompareTag( "Player" ) ) {
            _canvas.enabled = false;
        }
    }
}
