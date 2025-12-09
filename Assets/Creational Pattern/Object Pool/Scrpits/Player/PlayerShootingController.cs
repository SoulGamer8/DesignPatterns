using UnityEngine;

namespace Nevermindever.ObjectPool.Player {
    public class PlayerShootingController : MonoBehaviour {
        
        private bool _mouseDown = false;
        void Update() {

            if (Input.GetMouseButtonDown(0)) {
                Debug.Log("Mouse button pressed");
                _mouseDown = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("Mouse button up");
                _mouseDown = false;
            }

            if (_mouseDown)
            {
                
            }

        }
    }
}
