using UnityEngine;

namespace LocomotionSystem
{
    public class PawMoversController : MonoBehaviour
    {
        [SerializeField] private PawMover rightForwardPawMover;
        [SerializeField] private PawMover leftForwardPawMover;
        [SerializeField] private PawMover rightBackPawMover;
        [SerializeField] private PawMover leftBackPawMover;

        [Space]
        [SerializeField] private float distance;

        private void Start()
        {
            rightForwardPawMover.OnPawMoved += MoveLeftBackPaw;
            leftBackPawMover.OnPawMoved += MoveLeftFrontPaw;
            leftForwardPawMover.OnPawMoved += MoveRightBackPaw;
            rightBackPawMover.OnPawMoved += MoveRightFrontPaw;

            rightForwardPawMover.StartMovingPaw(0.4f);
        }

        private void MoveRightFrontPaw()
        {
            rightForwardPawMover.StartMovingPaw(0.6f);
        }

        private void MoveLeftFrontPaw()
        {
            leftForwardPawMover.StartMovingPaw(0.7f);
        }

        private void MoveRightBackPaw()
        {
            rightBackPawMover.StartMovingPaw(0.6f);
        }

        private void MoveLeftBackPaw()
        {
            leftBackPawMover.StartMovingPaw(0.6f);
        }
    }
}