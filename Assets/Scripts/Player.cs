using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        // Initialize # of seeds
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        // Player movements
        _playerTransform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0) * _speed * Time.deltaTime;

        // Player planting seed
        if (_numSeedsLeft > 0 && Input.GetKeyDown(KeyCode.Space)) {
            PlantSeed();
        }
    }

    // Plants a seed and updates # of seed left on UI
    public void PlantSeed ()
    {
        Debug.Log("Planting a seed!");

        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        _plantCountUI.UpdateSeeds(--_numSeedsLeft, ++_numSeedsPlanted);
    }
}
