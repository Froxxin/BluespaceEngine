using Game.Shared;

namespace Game.Server;

public sealed class ServerGame
{
    private readonly MovementSystem _movementSystem = new();
    private readonly InputSystem _inputSystem = new();

    public EntityManager EntityMAnager { get; } = new();

    public EntityId CreatePlayer()
    {
        var player = EntityManager.CreateEntity(); 
    }
}
