using UnityEngine;
using System.Collections;

public class UserData{

    public static int userPontos = 0;
    public static int userTime = 0;

    public static int numQuestao = 0;

    public static string ContarPontos(string valor)
    {
        if (valor.Equals("30"))
        {
            userPontos += 30 + userTime;
            return (30 + userTime).ToString();
        }
        else if (valor.Equals("10"))
        {
            userPontos += 10 + userTime;
            return (10 + userTime).ToString();
        }
        else if (valor.Equals("0"))
        {
            userPontos += 0;
            return "0";
        }
        else
        {
            return string.Empty;
        }
    }
}
