using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;

public class RunExternal : MonoBehaviour
{
    [Serializable]
    public enum GameIndex
    {
        RomanticTiming,
        ExamsOfP,
        GoDownTheRabbitHole,
        SchoolRoad,
        AsNote,
        Insider,
        SpaceGapHQ,
        TheBestOfFirstDayOperation,
        FirstDayOfSchool,
        ThirtyDaysToYou,
        SangSangEscape,
        TransferDiary
    }

    [SerializeField] GameIndex index;

    public void onClick()
    {
        string path = Application.dataPath, gameName = getGameName();

        Process.Start(path + gameName + "\\" + gameName + ".exe");
        Application.Quit();
    }

    string getGameName()
    {
        switch (index)
        {
            case GameIndex.RomanticTiming:
                return "RomanticTiming";
            case GameIndex.ExamsOfP:
                return "ExamsOfP";
            case GameIndex.GoDownTheRabbitHole:
                return "GoDownTheRabbitHole";
            case GameIndex.SchoolRoad:
                return "SchoolRoad";
            case GameIndex.AsNote:
                return "AsNote";
            case GameIndex.Insider:
                return "Insider";
            case GameIndex.SpaceGapHQ:
                return "SpaceGapHQ";
            case GameIndex.TheBestOfFirstDayOperation:
                return "TheBestOfFirstDayOperation";
            case GameIndex.FirstDayOfSchool:
                return "FirstDayOfSchool";
            case GameIndex.ThirtyDaysToYou:
                return "ThirtyDaysToYou";
            case GameIndex.SangSangEscape:
                return "SangSangEscape";
            case GameIndex.TransferDiary:
                return "TransferDiary";
            default:
                return "error";
        }
    }
}
