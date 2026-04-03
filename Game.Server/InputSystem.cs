using Game.Shared;

namespace Game.Server;

public sealed class InputSystem
{
    public void Update(EntityManager entityManager)
    {
        foreach (var entity in entityManager.GetEntitiesWithInputAndVelocity())
        {
            var input = entityManager.GetInput(entity);
            var velocity = entityManager.GetVelocity(entity);

            velocity.X = input.MoveX;
            velocity.Y = input.MoveY;

            entityManager.AddComponent(entity, velocity);
        }
    }
}