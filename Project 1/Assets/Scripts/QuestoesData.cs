using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestoesData {
    public static string[][] mPerguntas = new string[2][];

    public static void AddQuestao()
    {
        mPerguntas[0] = new string[10];

        //Pergunta #1
        mPerguntas[0][0] = "É normal vacinas provocarem reações ?";

        //Resposta #1
        mPerguntas[0][1] = "Sim, porque a vacina está estimulando a produção de anticorpos.";
        mPerguntas[0][2] = "Muito bem, você sabe mesmo! Reações como febre, cansaço, dor e vermelhidão local podem ocorrer " +
                                        "exatamente por isso, mas elas são geralmente transitórias (temporárias) e não fazem mal.";
        mPerguntas[0][3] = "30";

        //Resposta #2
        mPerguntas[0][4] = "Não, se ocorrer reações é porque algo está errado.";
        mPerguntas[0][5] = "É normal a ocorrência de reações, vacinas estimulam a produção de anticorpos e a " +
                                        "defesa do organismo. Isso pode causar febre, cansaço, dor e vermelhidão local, mas " +
                                        "são geralmente reações transitórias (temporárias) e não fazem mal.";
        mPerguntas[0][6] = "0";

        //Resposta #3
        mPerguntas[0][7] = "Sim. Se não ocorrerem reações, quer dizer que a vacina não fez efeito.";
        mPerguntas[0][8] = "Vacinas podem causar reações, mas isso não quer dizer que todo mundo vai senti-las. Isso não significa " +
                                        "que a vacina não está funcionando.";
        mPerguntas[0][9] = "10";

        /*
            Outra pergunta
        */

        mPerguntas[1] = new string[10];

        //Pergunta #2
        mPerguntas[1][0] = "------------------";

        //Resposta #1
        mPerguntas[1][1] = "----------------------";
        mPerguntas[1][2] = "Muito bem, você sabe mesmo! Reações como febre, cansaço, dor e vermelhidão local podem ocorrer " +
                                        "exatamente por isso, mas elas são geralmente transitórias (temporárias) e não fazem mal.";
        mPerguntas[1][3] = "30";

        //Resposta #2
        mPerguntas[1][4] = "----------------------";
        mPerguntas[1][5] = "É normal a ocorrência de reações, vacinas estimulam a produção de anticorpos e a " +
                                        "defesa do organismo. Isso pode causar febre, cansaço, dor e vermelhidão local, mas " +
                                        "são geralmente reações transitórias (temporárias) e não fazem mal.";
        mPerguntas[1][6] = "0";

        //Resposta #3
        mPerguntas[1][7] = "----------------------";
        mPerguntas[1][8] = "Vacinas podem causar reações, mas isso não quer dizer que todo mundo vai senti-las. Isso não significa " +
                                        "que a vacina não está funcionando.";
        mPerguntas[1][9] = "10";
    }

}
