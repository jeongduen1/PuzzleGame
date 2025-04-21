using UnityEngine;

public abstract class Tile : MonoBehaviour
{
    public int x, y;
    public abstract void OnClicked();
}