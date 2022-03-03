using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public static ButtonManager buttonManager;
    BattleAction battleAction;
    public MonoHero activeHero;
    public Button[] mainMenu;
    public Button[] magicMenu;
    public Button[] skillMenu;
    public Button[] itemMenu;
    public Button[] enemyMenu;
    public Button[] heroMenu;
    private void OnEnable()
    {
        buttonManager = this;
    }
    private void Start()
    {
        foreach (Button magicButton in magicMenu)
        {
            magicButton.onClick.AddListener(delegate { AttackEnemy(null); });
        }
    }

    public void OpenMainMenu()
    {
        foreach (Button mainButton in mainMenu)
            mainButton.gameObject.SetActive(true);
    }
    public void OpenMagicMenu()
    {
        foreach (Button magicButton in magicMenu)
            magicButton.gameObject.SetActive(true);
    }
    public void OpenSkillMenu()
    {
        foreach (Button skillButton in skillMenu)
            skillButton.gameObject.SetActive(true);
    }
    public void OpenItemMenuMenu()
    {
        foreach (Button itemButton in itemMenu)
            itemButton.gameObject.SetActive(true);
    }

    public void OpenEnemyMenu()
    {
        foreach (Button enemyButton in enemyMenu)
        {
            enemyButton.gameObject.SetActive(true);
        }
    }
    public void OpenHeroMenu()
    {
        foreach (Button heroButton in heroMenu)
        {
            heroButton.gameObject.SetActive(true);
        }

    }
    public void AttackEnemy(MonoEnemy enemy)
    {  
        activeHero.Attack(battleAction, enemy);
    }
    public void AttackMultipleEnemies()
    {

    }
    public void CloseMainMenu()
    {
        foreach (Button mainButton in mainMenu)
            mainButton.gameObject.SetActive(false);
    }
    public void CloseMagicMenu()
    {
        foreach (Button magicButton in magicMenu)
            magicButton.gameObject.SetActive(false);
    }
    public void CloseSkillMenu()
    {
        foreach (Button skillButton in skillMenu)
            skillButton.gameObject.SetActive(false);
    }
    public void CloseItemMenuMenu()
    {
        foreach (Button itemButton in itemMenu)
            itemButton.gameObject.SetActive(false);
    }
    public void CloseEnemyMenu()
    {
        
        foreach (Button enemyButton in enemyMenu)
            enemyButton.gameObject.SetActive(false);
        
    }

}
