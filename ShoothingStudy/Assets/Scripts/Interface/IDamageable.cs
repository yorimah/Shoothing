public interface IDamageable
{
    public int hp { get; set; }

    int defenceLayer { get; set; }

    public void TakeDamage(int damage);

    public void Die();
}
