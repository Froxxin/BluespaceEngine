namespace Game.Shared;

public sealed class EntityManager
{
    private int _nextEntityId = 1;

    private readonly Dictionary<int, TransformComponent>
    private readonly Dictionary<int, VelocityComponent>  
    private readonly Dictionary<int, InputComponent>
    private readonly Dictionary<int, PlayerControlledComponent>
    private readonly Dictionary<int, SpriteComponent>
}