using UnityEngine;
using UnityEngine.InputSystem;

public class MermiAtesi : MonoBehaviour
{

    public GameObject mermiPrefab; // Mermi prefabini inspector'dan atayın
    public Transform atesNoktasi; // Merminin çıkacağı nokta
    public float atesHizi = 20f; // Merminin hızı
    public float atesSuresi = 0.5f; // Mermi atış süresi

    

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject mermi = Instantiate(mermiPrefab, atesNoktasi.position, atesNoktasi.rotation);

            mermi.GetComponent<Rigidbody>().AddForce(atesNoktasi.forward * atesHizi, ForceMode.Impulse);

            Destroy(mermi, atesSuresi);
        }

    }
}
