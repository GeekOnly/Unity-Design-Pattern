using UnityEngine;

namespace Command
{
    public class PlayerController : MonoBehaviour
    {
        public Transform player;
        private CommandInvoker _invoker = new CommandInvoker();
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                ICommand moveForward = new MoveForwardCommand(player, 1.0f);
                _invoker.ExecuteCommand(moveForward);
            }

            if (Input.GetKeyDown(KeyCode.Z)) // Undo
            {
                _invoker.UndoLastCommand();
            }
        }
    }
}