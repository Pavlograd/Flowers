using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public enum MenuName
{
    None,
    Main,
    RoomEditor,
}

[System.Serializable]
public struct Menu
{
    public MenuName name; // name
    public GameObject gObject; // The GameObject of the menu
    public MenuName returnMenu; // The menu to return from this menu (does not appear if null)
}

public class UIManager : MonoBehaviour
{
    [SerializeField] Menu[] menus;
    [SerializeField] MenuName currentMenuName = MenuName.Main;
    [SerializeField] GameObject buttonReturn;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void DisplayMenu(string nameStr) // Hide all menus except the one you want to display
    {
        MenuName name = (MenuName)System.Enum.Parse(typeof(MenuName), nameStr);

        foreach (Menu menu in menus)
        {
            menu.gObject.SetActive(menu.name == name);
        }

        currentMenuName = name;
        buttonReturn.SetActive(GetCurrentMenu().returnMenu != MenuName.None); // Only show return button if current mennu has a return menu
    }

    public void Edit(bool edit)
    {
        GameManager.instance.editing = edit;
    }

    Menu GetCurrentMenu()
    {
        foreach (Menu menu in menus)
        {
            if (menu.name == currentMenuName) return menu;
        }

        return new Menu(); // In case there is no currentMenu
    }

    public void ReturnToMenu() // Return to returnMenu of current Menu
    {
        if (GameManager.instance.editing) Edit(false);
        DisplayMenu(GetCurrentMenu().returnMenu.ToString());
    }
}
