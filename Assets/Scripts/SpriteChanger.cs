using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    [SerializeField]
    Sprite sprite;

    private void OnMouseDown()
    {
        CharacterSpriteController characterSpriteController = FindObjectOfType<CharacterSpriteController>();
        characterSpriteController.ChangeSprite(sprite);
    }
}
