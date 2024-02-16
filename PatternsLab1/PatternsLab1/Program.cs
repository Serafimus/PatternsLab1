using PatternsLab1.Classes.Commands;
using PatternsLab1.Classes.ControlElements;
using PatternsLab1.Classes.Invoker;
using PatternsLab1.Interfaces;

public class Client
{
    static void Main(string[] args)
    {        
        Player John2942 = new Player();
        GameManager gameManager = new GameManager();
        
        InputManager inputManager = new InputManager();

        inputManager.SetCommand(0, new JumpCommand(John2942));
        inputManager.SetCommand(1, new GrabCommand(John2942));
        inputManager.SetCommand(2, new ThrowCommand(John2942));
        inputManager.SetCommand(3, new SaveCommand(gameManager));
        inputManager.SetCommand(4, new QuitCommand(gameManager));
        inputManager.SetCommand(5, new MoveCommand(John2942));
        inputManager.SetCommand(6, new MacroCommand(new SaveCommand(gameManager), new QuitCommand(gameManager)));

        Console.WriteLine(inputManager);
        inputManager.OnButtonPressed(0);
        inputManager.OnButtonPressed(2);
        inputManager.OnButtonPressed(1);
        //inputManager.OnButtonPressed(4);
        inputManager.OnButtonPressed(6);

        Console.WriteLine("Текст, который не выведется");
    }
}