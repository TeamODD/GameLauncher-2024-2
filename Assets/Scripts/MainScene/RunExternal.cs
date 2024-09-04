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
        ptc,
        EndOfWorld,
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
            case GameIndex.ptc:
                return "ptc";
            case GameIndex.EndOfWorld:
                return "EndOfWorld";
            default:
                return "error";
        }
    }
}
