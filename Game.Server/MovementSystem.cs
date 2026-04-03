using Game.Shared;


namespace Game.Server;

public sealed class MovementSystem
{
    public void Update(EntityManager entitymanager, float deltaTime)
    {
        foreach (var entity in entitymanager.GetEntitiesWithMovement())
        {
            ref var transform = ref entitymanager.GetTransform(entity);
            ref var velocity = ref entitymanager.GetVelocity(entity);

            transform.X += velocity.X * deltaTime;
            transform.Y += velocity.Y * deltaTime;
        }
    }
}
