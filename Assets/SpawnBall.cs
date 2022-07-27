using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnBall : MonoBehaviour
{
    //SerializeField allows unity to access and modify the variable
    //private means that no other class can access the variable/function
    //public means that unity and other classes can access the variable/function
    public GameObject ballPrefab;
    [SerializeField] private GameObject _surpriseImage;
    [SerializeField] private Vector3 _position;
    [SerializeField] private TMP_Text _text;

    private int _ballCount = 0;

    //int         - Whole numbers: -3, -2, -1, 0,1,2,3,4,5,6,7,8,9
    //float       - Decimals: 0.4, -0.6
    //string      - words/character/letter "0"
    //bool        - True or False

    private void Start()
    {
        //_text.text = "Hi";
    }

    //variables store values/data
    public void SpawnOnButton()
    {
        Debug.Log("Pressed");

        //variable we made is called randomx
        float randomx = Random.Range(-0.7f,0.7f); // the f means float

        _position.x += randomx;

        Instantiate(ballPrefab, _position, Quaternion.identity);
        _ballCount += 1;
        //or ballCount++; as ++ will increase the number by 1
        _text.text = _ballCount.ToString();

        // left == right  //checking if the values are the same
        // left < right   //is the left value less than the right
        // left > right   //same as above but is left value greater than the right
        // left <= right  //less than or equal to
        // left => right  //greater than or equal to
        if(_ballCount > 20)
        {
            // we only run code if the above statement is true

            _surpriseImage.SetActive(true); //set surprise image to active
        }
    }
}
