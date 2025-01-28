using UnityEngine;

namespace LocomotionSystem
{
    public class PawMoversController : MonoBehaviour
    {
        [SerializeField] private PawMover rightForwardPawMover;
        [SerializeField] private PawMover leftForwardPawMover;
        [SerializeField] private PawMover rightBackPawMover;
        [SerializeField] private PawMover leftBackPawMover;

        private void Start()
        {
            rightForwardPawMover.OnPawMoved += leftBackPawMover.StartMovingPaw;
            leftBackPawMover.OnPawMoved += leftForwardPawMover.StartMovingPaw;
            leftForwardPawMover.OnPawMoved += rightBackPawMover.StartMovingPaw;
            rightBackPawMover.OnPawMoved += rightForwardPawMover.StartMovingPaw;

            rightForwardPawMover.StartMovingPaw();
        }
    }
}