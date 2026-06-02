using UnityEngine;
using Player;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform target;
    public PlayerMovement player;
    public float smoothSpeed = 5f;
    public float lookAheadDistance = 2f;

    public Vector2 minBounds;
    public Vector2 maxBounds;

    private float currentLookAhead;

    private void LateUpdate()
    {
        if (target == null || player == null)
            return;

        if (player.IsFacingRight)
        {
            currentLookAhead = lookAheadDistance;
        }
        else
        {
            currentLookAhead = -lookAheadDistance;
        }

        Vector3 targetPosition = new Vector3(target.position.x + currentLookAhead, target.position.y, transform.position.z);

        float clampedX = Mathf.Clamp(targetPosition.x, minBounds.x, maxBounds.x);
        float clampedY = Mathf.Clamp(targetPosition.y, minBounds.y, maxBounds.y);

        Vector3 clampedPosition = new Vector3(clampedX, clampedY, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, clampedPosition, smoothSpeed * Time.deltaTime);
    }

    public void TestClampPosition(Vector3 fakeTargetPosition)
    {
        Vector3 targetPosition = new Vector3(fakeTargetPosition.x, fakeTargetPosition.y, transform.position.z);

        float clampedX = Mathf.Clamp(targetPosition.x, minBounds.x, maxBounds.x);
        float clampedY = Mathf.Clamp(targetPosition.y, minBounds.y, maxBounds.y);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}