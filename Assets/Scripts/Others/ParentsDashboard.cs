using Others;
using UnityEngine;
using UnityEngine.UI;

public class ParentsDashboard : MonoBehaviour
{
    public Text MatchColorCorrect;
    public Text MatchColorWrong;
    public Text CountingEggsCorrect;
    public Text CountingEggsWrong;
    public Text PopTheBalloonCorrect;
    public Text PopTheBalloonWrong;
    public Text FindTheDifferenceCorrect;
    public Text FindTheDifferenceWrong;
    public Text SizeGameCorrect;
    public Text SizeGameWrong;


    private void Start()
    {
        MatchColorCorrect.text = SceneDataHandler.LoadSceneData("Game_Color").correct.ToString();
        MatchColorWrong.text = SceneDataHandler.LoadSceneData("Game_Color").wrong.ToString();
        CountingEggsCorrect.text = SceneDataHandler.LoadSceneData("Game_Counting").correct.ToString();
        CountingEggsWrong.text = SceneDataHandler.LoadSceneData("Game_Counting").wrong.ToString();
        PopTheBalloonCorrect.text = SceneDataHandler.LoadSceneData("Game_Shapes").correct.ToString();
        PopTheBalloonWrong.text = SceneDataHandler.LoadSceneData("Game_Shapes").wrong.ToString();
        FindTheDifferenceCorrect.text = SceneDataHandler.LoadSceneData("Game_Difference").correct.ToString();
        FindTheDifferenceWrong.text = SceneDataHandler.LoadSceneData("Game_Difference").wrong.ToString();
        SizeGameCorrect.text = SceneDataHandler.LoadSceneData("Game_Size").correct.ToString();
        SizeGameWrong.text = SceneDataHandler.LoadSceneData("Game_Size").wrong.ToString();


    }
    
}
