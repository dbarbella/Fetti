/* Creates a lattice of pegs that balls can bounce off of.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePegboard : MonoBehaviour
{
    public float boardWidth;
    public float boardHeight;
    private float leftPosition;
    private float topPosition;
    private float pegGapHorizontal;
    private float pegGapVertical;
    private float nextVerticalPosition;
    private float horizontalOffset = 0;
    private int offsetOn = 0;

    private Vector2 pegPosition;

    public GameObject peg;
    public int pegsPerRow;
    public int pegRows;
    public float pegScale;
    
    void Start()
    {
        leftPosition = transform.position.x - (boardWidth / 2);
        topPosition = transform.position.y + (boardHeight / 2);
        pegGapHorizontal = boardWidth / pegsPerRow;
        pegGapVertical = boardHeight / pegRows;
        nextVerticalPosition = topPosition;
        horizontalOffset = pegGapHorizontal / 2;

        for (int row = 0; row < pegRows; row++)
        {
            for (int i = 0; i < pegsPerRow; i++)
            {
                pegPosition = new Vector2(leftPosition + i * pegGapHorizontal + (offsetOn * horizontalOffset), nextVerticalPosition);
                Instantiate(peg, pegPosition, transform.rotation);
            }
            offsetOn = offsetOn ^ 1; // If offsetOn equals 0, now it equals 1, and vice versa.
            nextVerticalPosition -= pegGapVertical;
        }
    }
}
