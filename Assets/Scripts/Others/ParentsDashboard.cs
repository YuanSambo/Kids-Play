using Others;
using UnityEngine;
using UnityEngine.UI;

public class ParentsDashboard : MonoBehaviour
{
    public Text MatchColorCorrect;
    public Text MatchColorWrong;
    public Text MatchColorAverage;
    public Text CountingEggsCorrect;
    public Text CountingEggsWrong;
    public Text CountingEggsAverage;
    public Text PopTheBalloonCorrect;
    public Text PopTheBalloonWrong;
    public Text PopTheBalloonAverage;
    public Text FindTheDifferenceCorrect;
    public Text FindTheDifferenceWrong;
    public Text FindTheDifferenceAverage;
    public Text SizeGameCorrect;
    public Text SizeGameWrong;
    public Text SizeGameAverage;



    private void Start()
    {
        MatchColorCorrect.text = SceneDataHandler.LoadSceneData("Game_Color").Correct.ToString();
        MatchColorWrong.text = SceneDataHandler.LoadSceneData("Game_Color").Wrong.ToString();
        MatchColorAverage.text = SceneDataHandler.LoadSceneData("Game_Color").GetAveragePlayTime();
        
        CountingEggsCorrect.text = SceneDataHandler.LoadSceneData("Game_Counting").Correct.ToString();
        CountingEggsWrong.text = SceneDataHandler.LoadSceneData("Game_Counting").Wrong.ToString();
        CountingEggsAverage.text = SceneDataHandler.LoadSceneData("Game_Counting").GetAveragePlayTime();

        PopTheBalloonCorrect.text = SceneDataHandler.LoadSceneData("Game_Shapes").Correct.ToString();
        PopTheBalloonWrong.text = SceneDataHandler.LoadSceneData("Game_Shapes").Wrong.ToString();
        PopTheBalloonAverage.text = SceneDataHandler.LoadSceneData("Game_Shapes").GetAveragePlayTime();

        FindTheDifferenceCorrect.text = SceneDataHandler.LoadSceneData("Game_Difference").Correct.ToString();
        FindTheDifferenceWrong.text = SceneDataHandler.LoadSceneData("Game_Difference").Wrong.ToString();
        FindTheDifferenceAverage.text = SceneDataHandler.LoadSceneData("Game_Difference").GetAveragePlayTime();

        
        SizeGameCorrect.text = SceneDataHandler.LoadSceneData("Game_Size").Correct.ToString();
        SizeGameWrong.text = SceneDataHandler.LoadSceneData("Game_Size").Wrong.ToString();
        SizeGameAverage.text = SceneDataHandler.LoadSceneData("Game_Size").GetAveragePlayTime();



    }
    
}
