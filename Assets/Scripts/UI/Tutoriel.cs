using UnityEngine;

public class Tutoriel : MonoBehaviour
{
    public string animParameter; 
    private Animator tutorielAnim;

    // Start is called before the first frame update
    void Start()
    {
        tutorielAnim = this.GetComponent<Animator>();    
    }

    public void OffTutoriel()
    {
        tutorielAnim.SetBool(animParameter, true); 
    }
}
