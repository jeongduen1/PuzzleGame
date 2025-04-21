using UnityEngine;

public class EmptyTile : Tile
{
    public override void OnClicked()
    {
        Debug.Log("EmptyClicked");
    }
}
