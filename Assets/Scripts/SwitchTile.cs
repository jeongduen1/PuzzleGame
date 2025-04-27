using UnityEngine;

public class SwitchTile : Tile
{
    public override void OnClicked()
    {
        TileManager.Instance.ToggleLightsAround(x, y);
        SoundManager.Instance.SwitchEffect();
    }

    private void OnMouseDown() => OnClicked();
}