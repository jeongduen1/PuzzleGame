using UnityEngine;

public class SwitchTile : Tile
{
    public override void OnClicked()
    {
        TileManager.Instance.ToggleLightsAround(x, y);
    }

    private void OnMouseDown() => OnClicked();
}