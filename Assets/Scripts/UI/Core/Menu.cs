using UnityEngine;

/*
 * Menu (Core menu base class file)
 * ----
 * The core menu base class enables the user to easily manage any menu overlay.
 */

public abstract class Menu : MonoBehaviour
{
    // Common functionality for all menus:
    public virtual void Open() => gameObject.SetActive(true);
    public virtual void Close() => gameObject.SetActive(false);
}
