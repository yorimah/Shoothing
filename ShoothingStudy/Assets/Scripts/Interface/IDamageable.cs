public interface IDamageable
{
    public int hp { get; set; }

    int defenceLayer { get; set; }

    public void TakeDamage(int damege);

    public void Die();
}
