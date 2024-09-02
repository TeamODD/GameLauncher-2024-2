using UnityEngine;
using System.Diagnostics;
using System;

public class RunExternal : MonoBehaviour
{
    [Serializable]
    public enum GameIndex
    {
        SteamExorcist,
        PHYLLOSOMA,
        Game3,
        Game4,
    }

    [SerializeField] GameIndex index;

    public void onClick()
    {
        string path = Application.dataPath + "\\Games\\", gameName = getGameName();

        Process.Start(path + gameName + "\\" + gameName + ".exe");
        Application.Quit();
    }

    string getGameName()
    {
        switch (index)
        {
            case GameIndex.SteamExorcist:
                return "SteamExorcist";
            case GameIndex.PHYLLOSOMA:
                return "PHYLLOSOMA";
            case GameIndex.Game3:
                return "Game3";
            case GameIndex.Game4:
                return "Game4";
            default:
                return "error";
        }
    }
}
