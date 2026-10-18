using UnityEngine;
// TODO: crea el ScriptableObject [CreateAssetsMenu...] recorda que no ha d'heretar de MonoBehaviour
[CreateAssetMenu(fileName = "NewAsteroidData", menuName = "Asteroids/Asteroid Data")]
public class AsteroidData : ScriptableObject
{
    //TODO: introdueix les dades necesaties
    public int maxHealth = 1;
    public Color color = Color.white;
    public float scale = 1f;
    public float minSpeed = 2f;
    public float maxSpeed = 5f;
    public int scoreValue = 100;
    public int damage = 1;
}
