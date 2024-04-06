using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip hadokenSound, enemyHadokenSound, jumpSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        hadokenSound = Resources.Load<AudioClip>("PL01.PAC_00000");
        enemyHadokenSound = Resources.Load<AudioClip>("PL00.PAC_00000");
        jumpSound = Resources.Load<AudioClip>("PL01.PAC_00008");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Hadoken":
                audioSrc.PlayOneShot(hadokenSound);
                break;
            case "Jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "EnemyHadoken":
                audioSrc.PlayOneShot(enemyHadokenSound);
                break;
        }
    }
}
