using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localizacion_lang : MonoBehaviour
{
    [Header("list")]
    [SerializeField]
    List<string> listOfNames = new List<string> { "Hello", "hi" };

    [Header("Dictionary")]
    [SerializeField]
    Dictionary<string, int> mainDictionary = new Dictionary<string, int>
    {
        {"Hello", 1 }, {"hi", 5 } 
    };

    [Header("Check")]
    [SerializeField]
    string justChecking;

}

/*
  public enum Language { English, Español, Português, Pусский, ελληνικα, 日本語_Jp, 한국어_Kr, Deutsch }
    public Language setLanguage;

    public enum KeyWord { New_game, Continue, Options, Exit }
    public KeyCode setWording;

    string[,] names = new string[8, 4]
    {
        {"New game ","Continue ","Options ","Exit " },
        {"Nueva Partida ","Continuar ","Opciones ","Salir " },
        {"Novo Jogo ","Continuar","Opções ","Sair " },
        {"Новая игра ","Загрузить игру ","Настройки ","Выход " },
        {"Νέο παιχνίδι ","Άνοιγμα παιχνιδιού ","Επιλογές ","Έξοδος " },
        {"新しいゲーム ","ロード ","設定 ","終了する " },
        {"새 게임 ","불러오기 ","설정 ","종료 " },
        {"Neues Spiel ","Optionen ","Laden ","Beenden " },
    };

    public void Update()
    {
        this.GetComponent<Text>().text = names[(int)setLanguage, (int)setWording];
    }

 */
