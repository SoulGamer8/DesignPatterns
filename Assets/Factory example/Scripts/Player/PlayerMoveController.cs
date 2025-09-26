using UnityEngine;

namespace Nevermindever.Player {
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMoveController : MonoBehaviour {
        [SerializeField] private float speed = 5f;
        private Rigidbody2D _rb;
        private Vector2 _moveInput;

        void Awake() {
            _rb = GetComponent<Rigidbody2D>();
            _rb.freezeRotation = true;
        }

        void Update() {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            _moveInput = new Vector2(x, y).normalized;
        }

        void FixedUpdate() {
            _rb.linearVelocity = _moveInput * speed;
        }
    }
}
