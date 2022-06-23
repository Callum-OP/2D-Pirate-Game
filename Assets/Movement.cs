using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var vMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vMovement, 0) * Time.deltaTime * movementSpeed;
        var hMovement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hMovement, 0, 0) * Time.deltaTime * movementSpeed;

        // Flip the character
        Vector3 characterScale = transform.localScale;
            if (hMovement < 0)
            {
                characterScale.x = -1;
            }
            else if (hMovement > 0)
            {
                characterScale.x = 1;
            }
        transform.localScale = characterScale;
    }
}
