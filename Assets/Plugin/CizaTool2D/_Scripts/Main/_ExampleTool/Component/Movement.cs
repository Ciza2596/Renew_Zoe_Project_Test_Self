using CizaTool2D.ExampleTool.Func;
using UnityEngine;

namespace CizaTool2D.ExampleTool.Component
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed = 5;

        [SerializeField] private GameObject converter;

        private Func.Movement movement;

        private void Awake() => movement = new Func.Movement()
                                    .SetTransform(converter.GetComponent<ITransform>());

        private void Update() => movement.SetSpeed(speed)
                                          .Update();
    }
}
