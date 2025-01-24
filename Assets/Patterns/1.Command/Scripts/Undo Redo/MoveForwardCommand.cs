using UnityEngine;

namespace Command
{
    public class MoveForwardCommand : ICommand
    {
        private Transform _player;
        private float _distance;

        public MoveForwardCommand(Transform player, float distance)
        {
            _player = player;
            _distance = distance;
        }

        public void Execute()
        {
            _player.Translate(Vector3.forward * _distance);
        }

        public void Undo()
        {
            _player.Translate(Vector3.back * _distance);
        }
    }
}