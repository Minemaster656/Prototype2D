using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    [SerializeField] public static KeyCode keyW = KeyCode.W;
    [SerializeField] public static KeyCode keyJump = KeyCode.Space;
    [SerializeField] public static KeyCode keyA = KeyCode.A;
    [SerializeField] public static KeyCode keyD = KeyCode.D;
    [SerializeField] public static KeyCode keyS = KeyCode.S;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
