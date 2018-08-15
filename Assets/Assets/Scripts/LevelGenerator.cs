using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public Texture2D map;
    public ColorToPrefab[] colorMappings;

    void Start()
    {
        GenerateLevel();
    }



    private void GenerateLevel()
    {
        /**
        * Loops around the each pixel from the given map
        */

        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                GenerateTile(x, y);
            }
        }
    }



    private void GenerateTile(int x, int y)
    {
        /**
        * Decides what object to instantiate based on the specific color pixel
        */

        Color pixelColor = map.GetPixel(x, y);

        if (pixelColor.a == 0)
        {
            // pixel color is transparent. Let's ignore it
            return;
        }
        Debug.Log(pixelColor);

        //
        foreach(ColorToPrefab colorMapping in colorMappings)
        {
            Vector2 position = new Vector2(x, y);
            if (colorMapping.color.Equals(pixelColor))
            {
                Instantiate(colorMapping.prefab, position, Quaternion.identity, transform);
            }
        }
    }

}
