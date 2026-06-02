using UnityEngine;

public class SpikeHazard : Hazard
{
    // Called when the game starts
    private void Start()
    {
        // Activate the spike hazards when the game starts
        Activate();
    }

    // Called when another collider enters the spike hazard's trigger area
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isActive)
        {
            return;
        }

        // Checks if the object that entered the trigger area is the player safely matching the namespace path
        Player.Player player = collision.gameObject.GetComponent<Player.Player>();
        if (player != null)
        {
            ApplyEffect(player);
        }
    }

    // Takes 1 damage from the player when they enter the spike hazard's trigger area
    public override void ApplyEffect(Player.Player player) // Fixed type path ambiguity
    {
        player.TakeDamage(1);
    }
}