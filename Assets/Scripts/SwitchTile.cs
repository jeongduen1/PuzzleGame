using UnityEngine;

public class SwitchTile : Tile
{
    public SpriteRenderer myRenderer;

    private void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
    }

    public override void OnClicked()
    {
        TileManager.Instance.ToggleLightsAround(x, y);
        myRenderer.flipY = true;
    }

    private void OnMouseDown() => OnClicked();
}