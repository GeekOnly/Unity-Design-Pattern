using UnityEngine;

namespace Command
{
    public class MoveCommand : ICommand
    {
        private Transform _objectToMove;
        private Vector3 _direction;
        private float _distance;

        public MoveCommand(Transform objectToMove, Vector3 direction, float distance)
        {
            _objectToMove = objectToMove;
            _direction = direction;
            _distance = distance;
        }

        public void Execute()
        {
            _objectToMove.Translate(_direction * _distance);
        }

        public void Undo()
        {
            _objectToMove.Translate(-_direction * _distance);
        }
    }
}