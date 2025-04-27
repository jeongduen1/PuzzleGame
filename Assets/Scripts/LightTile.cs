using UnityEngine;

public class LightTile : Tile
{
    public bool isOn = false;
    private SpriteRenderer myRenderer;
    public Sprite onSprite, offSprite;

    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        UpdateSprite();
    }

    public override void OnClicked() { }

    public void Toggle()
    {
        isOn = !isOn;
        UpdateSprite();
    }

    void UpdateSprite()
    {
        myRenderer.sprite = isOn ? onSprite : offSprite;
    }
}