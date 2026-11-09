using UnityEngine;

public class MermiCarpma : MonoBehaviour
{
    public GameObject carpmaEfektiPrefab; // Çarpma efekti prefabini inspector'dan atayın

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("Zemin"))
        {
            // Çarpma noktasında çarpma efektini oluştur
            ContactPoint temas = collision.GetContact(0);

            Instantiate(carpmaEfektiPrefab, temas.point, Quaternion.LookRotation(temas.normal));

            Destroy(gameObject); // Mermiyi yok et

        }
       


      
    }


}
