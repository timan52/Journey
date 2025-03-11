using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JourneyInterfaceScript : MonoBehaviour
{
    Animator JourneyAnimator;
    [SerializeField]
    private GameObject HeroField;
    [SerializeField]
    private GameObject HeroPrefab;
    [SerializeField]
    private GameObject QuestField;
    [SerializeField]
    private GameObject QuestPrefab;
    [SerializeField]
    private GameObject Deck;
    [SerializeField]
    public GameObject Field;

    private GameObject GameManager;
    private GameManagerScript GameManagerScript;
    private void Awake()
    {
        GameManager = GameObject.Find("GameManager");
        GameManagerScript = GameManager.GetComponent<GameManagerScript>();
        JourneyAnimator = GetComponent<Animator>();
    }
    public void initinalLoad(GameObject Hero, GameObject Quest)
    {

        setHeroSetQuest(Hero, Quest);
        JourneyAnimator.SetTrigger("DeckVanish");
        Deck.SetActive(true);

    }
    public void setDeckInAktive()
    {
        Deck.SetActive(false);
    }

    public void setHeroSetQuest(GameObject Hero, GameObject Quest)
    {
        HeroPrefab = Instantiate(Hero, new Vector3 (HeroField.transform.position.x, HeroField.transform.position.y, HeroField.transform.position.z), HeroField.transform.rotation, this.transform);
        GameManagerScript.setHeroCard(HeroPrefab);
        QuestPrefab = Instantiate(Quest, new Vector3(QuestField.transform.position.x, QuestField.transform.position.y, QuestField.transform.position.z), QuestField.transform.rotation, this.transform);
        GameManagerScript.setQuestCard(QuestPrefab);

    }
    public void loadFieldCards()
    {
        GameManagerScript.setUpGame();
    }

}
