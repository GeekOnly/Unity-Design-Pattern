using UnityEngine;

namespace Command
{
    public class PlayerControllerUndoRedo : MonoBehaviour
    {
        public Transform player;
        private CommandManager _commandManager = new CommandManager();

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W)) // Move Forward
            {
                ICommand moveCommand = new MoveCommand(player, Vector3.forward, 1.0f);
                _commandManager.ExecuteCommand(moveCommand);
            }

            if (Input.GetKeyDown(KeyCode.S)) // Move Backward
            {
                ICommand moveCommand = new MoveCommand(player, Vector3.back, 1.0f);
                _commandManager.ExecuteCommand(moveCommand);
            }

            if (Input.GetKeyDown(KeyCode.A)) // Move Left
            {
                ICommand moveCommand = new MoveCommand(player, Vector3.left, 1.0f);
                _commandManager.ExecuteCommand(moveCommand);
            }

            if (Input.GetKeyDown(KeyCode.D)) // Move Right
            {
                ICommand moveCommand = new MoveCommand(player, Vector3.right, 1.0f);
                _commandManager.ExecuteCommand(moveCommand);
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                _commandManager.Undo();
            }

            if(Input.GetKeyDown(KeyCode.X))
            {
                _commandManager.Redo();
            }
        }
    }
}